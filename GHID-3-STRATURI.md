# 3 straturi — ghid de lucru

**Pentru:** Ana · **Proiect:** `structuri` · **Data:** 2026-08-05

Proiectul a fost reorganizat: fiecare model are acum **folderul lui**, iar în folder stau
**cele 3 straturi**. `Program.cs` a rămas cu două linii — exercițiile vechi au fost șterse din el.

Nu s-au pierdut: sunt în istoricul git. Oricând vrei să te uiți la ele:

```bash
git show a6501ce:Program.cs
```

---

## De ce facem asta

Până azi, `Program.cs` avea **1755 de linii**. Numără în el (`git show a6501ce:Program.cs`)
de câte ori apare bucla asta:

```csharp
Produs gasit = null;
for (int i = 0; i < produse.Count; i++)
{
    if (produse[i].nume.Equals(cautat))
        gasit = produse[i];
}
```

De **nouă** ori: `Exercitiul13`, `CRUD9`, `CRUD10`, `CRUD11`, `Exercitiul15`, Pizza, Cinema, Joc,
Adăpost, Playlist. Aceeași buclă, alt nume de variabilă.

Întrebarea care contează: **dacă vrei să adaugi `break` ca să nu mai parcurgi lista degeaba,
în câte locuri trebuie să te duci?** În nouă. Și dacă greșești într-unul, nu se vede nicăieri.

Trei dintre bugurile din `CODE_REVIEW_3.md` (B1 Cinema, B2 Adăpost, B3 Jocuri) au exact cauza asta:
ai rescris de fiecare dată *decizia de după găsire*, și de fiecare dată puțin altfel.

Cu 3 straturi, bucla se scrie **o singură dată**, iar decizia are **un singur loc**.

---

## Harta proiectului

```
structuri/
├── Program.cs              <- Main, doua linii. Atat.
├── Studenti/
│   ├── Student.cs          <- MODEL: ce ESTE un student (campuri)
│   ├── StudentService.cs   <- SERVICE: lista + operatiile pe ea
│   ├── StudentView.cs      <- VIEW: meniul, tastele, mesajele
│   └── README.md           <- exercitiile tale
├── Produse/                <- Produs + ProdusService + ProdusView + README
├── Pizze/                  <- Pizza + ...
├── Filme/                  <- Film + ...
├── Jocuri/                 <- Joc + ...
├── Adaposturi/             <- Adapost + ...
├── Melodii/                <- Melodie + ...
├── Autentificare/          <- Utilizatori + User + ...
└── ConturiBancare/         <- ContBancar + ...
```

**Folderul e la plural, clasa e la singular.** Folderul `Studenti` ține mai mulți; clasa `Student`
descrie unul singur. Regula asta răspunde și la M5 din review: `Adapost` e numele locului unde stau
animalele — folderul. Clasa ar trebui să se numească `Animal`, pentru că un obiect e un animal, nu un adăpost.
(E exercițiul A4 din `Adaposturi/README.md`.)

**În afară de `Studenti/`, toate fișierele `Service` și `View` sunt goale.** Le scrii tu, folosind
cerințele din `README.md`-ul fiecărui folder.

---

## Cele 3 straturi, în trei propoziții

| Strat | Fișier | Răspunde la întrebarea | Are voie să… |
|---|---|---|---|
| **Model** | `Student.cs` | *Ce este un student?* | țină câmpuri și calcule despre el însuși |
| **Service** | `StudentService.cs` | *Ce operații fac cu studenții?* | țină lista, caute, adauge, șteargă |
| **View** | `StudentView.cs` | *Cum vorbesc cu omul din fața ecranului?* | meniu, `Console.WriteLine`, `Console.ReadLine`, și **cheamă service-ul** |

### Regula de aur

> **Service-ul n-are voie să atingă consola. View-ul n-are voie să caute cu `for` în listă.**

View-ul are voie să *ceară* — `service.Cauta(nume)` — dar nu să scotocească el prin listă.
Service-ul are voie să *calculeze* — dar nu să scrie un rând pe ecran.

Testul: *dacă mâine aplicația ar deveni o pagină web, câte fișiere atingi?*
Unul singur — View-ul. Service-ul rămâne neschimbat, pentru că el nu știe că există un ecran.
Asta e tot ce cumperi cu împărțirea în straturi.

**Direcția e într-un singur sens:** `Main → View → Service → Model`.
Modelul nu știe de service. Service-ul nu știe de view.

---

## Citește întâi etalonul

`Studenti/` e singurul folder scris complet. Citește-l înainte de orice — restul le completezi tu,
după modelul lui.

### În `StudentService`, trei lucruri noi

**1. Lista e câmp al clasei, nu variabilă locală.**

```csharp
private List<Student> studenti = new List<Student>();
```

Până acum lista se năștea și murea în interiorul unei metode. Acum obiectul `service` **ține minte**
între apeluri: adaugi într-o linie, cauți în alta, lista e tot acolo.

`private` înseamnă „nimeni din afară nu ajunge la listă". Dacă ar fi `public`, View-ul ar scormoni
direct în ea și stratul ar fi decorativ — un fișier în plus, fără nicio graniță reală.

**2. O metodă poate returna un obiect sau `null`.**

```csharp
public Student Cauta(string nume)
{
    for (int i = 0; i < studenti.Count; i++)
    {
        if (studenti[i].nume.Equals(nume))
        {
            return studenti[i];
        }
    }

    return null;
}
```

Ai returnat până acum `bool` (`Login`) și `double` (`ValoareStoc`), dar niciodată un **obiect**.

Și observă: `return studenti[i]` **iese din metodă pe loc**. Nu mai ai nevoie de `break`, și nu mai
păstrezi din greșeală ultima potrivire în loc de prima — cum se întâmpla în toate cele 9 bucle vechi.

**3. `Sterge` cheamă `Cauta`.**

```csharp
Student gasit = Cauta(nume);
if (gasit == null) { return false; }
studenti.Remove(gasit);
```

Nu mai e nevoie de `RemoveAt(i)` din buclă (M1 din review). Cauți, apoi ștergi obiectul găsit.
Un serviciu își folosește propriile metode.

---

## `Play()` — meniul

`Program.cs` are acum două linii:

```csharp
static void Main(string[] args)
{
    StudentView view = new StudentView();
    view.Play();
}
```

Iar `Play()`, din `StudentView.cs`, e bucla de meniu. **E doar un dispecer:**

```csharp
public void Play()
{
    int tasta;
    do
    {
        Console.WriteLine("Apasati tasta 0 pentru a iesi");
        Console.WriteLine("Apasati tasta 1 pentru a adauga un student");
        Console.WriteLine("Apasati tasta 2 pentru a afisa toti studentii");
        Console.WriteLine("Apasati tasta 3 pentru a cauta un student");
        Console.WriteLine("Apasati tasta 4 pentru a sterge un student");
        tasta = Int32.Parse(Console.ReadLine());

        switch (tasta)
        {
            case 0: return;
            case 1: Adaugare(); break;
            case 2: Afisare(); break;
            case 3: Cautare(); break;
            case 4: Stergere(); break;
            default: InputGresit(); break;
        }
    }
    while (tasta != 0);
}
```

`Play()` nu face treaba, ci **decide cine o face**. Munca stă în metode scurte (`Adaugare`, `Afisare`,
`Cautare`, `Stergere`), fiecare cu aceeași formă în trei pași:

> **întreabă omul → cheamă service-ul → spune rezultatul**

```csharp
public void Cautare()
{
    Console.Write("Nume cautat: ");
    string nume = Console.ReadLine();

    Student gasit = service.Cauta(nume);      // <- tot ce era buclă, într-o linie

    if (gasit == null)
    {
        Console.WriteLine("Studentul nu exista");
        return;
    }

    Console.WriteLine(gasit.nume + " - media " + gasit.medie);
}
```

Compară metoda asta cu vechiul `Exercitiul13` (`git show a6501ce:Program.cs`): aceeași treabă,
dar acolo bucla de căutare stătea în `Main`, amestecată cu afișarea.

Și acum vine plata: **ca să adaugi opțiunea „5. Studenți promovați" scrii un `case`, o metodă de
5 linii și una în service.** Nu copiezi nimic. Ăsta e tot rostul împărțirii pe straturi —
un loc nou de adăugat, nu nouă.

**Al treilea concept nou: `do / while` cu `switch`.** `do` execută întâi, apoi verifică — de-asta
meniul apare măcar o dată. `switch (tasta)` e același lucru cu un lanț de `if / else if`, doar
că se citește mai ușor când ai 6 opțiuni. `default:` prinde orice tastă care nu e în meniu.

---

## Ordinea de lucru

Toate folderele au aceeași temă: scrii `Service` și `View` de la zero, după cerințele din
`README.md`-ul lor. Ordinea de mai jos e cea în care se sprijină unul pe altul.

| # | Folder | De ce aici |
|---|---|---|
| 0 | `Studenti/` | etalonul — îl **citești** și îl rulezi, nu-l scrii |
| 1 | `Produse/` | cel mai aproape de etalon; modelul are deja metode gata (`ValoareStoc`, `AplicaReducere`) |
| 2 | `Pizze/` | același tipar, dar decizia are trei rezultate, nu două |
| 3 | `Filme/` | prima metodă care **schimbă** starea: verifici locurile, *apoi* scazi (B1) |
| 4 | `Jocuri/` | apare cazul „era deja făcut" (B3) |
| 5 | `Adaposturi/` | condiția care era pe dos (B2) + redenumirea clasei în `Animal` |
| 6 | `Melodii/` | formatare (`mm:ss`) și ordonare cu bucle |
| 7 | `Autentificare/` | validări și stare care se ține minte (cont blocat după 3 greșeli) |
| 8 | `ConturiBancare/` | cel mai greu: transferul, unde ori se întâmplă tot, ori nimic |

La pașii 3, 4 și 5 metoda cerută e **exact** locul unde au apărut B1, B2 și B3. De data asta o scrii
o singură dată, într-un singur loc — și dacă e corectă acolo, e corectă peste tot.

**Fiecare folder are propriul `README.md`** cu 16–19 exerciții pe nivele: meniul, CRUD complet,
operațiile specifice aplicației, rapoarte, cazuri limită. Sunt fără indicii — primești cerința și
DoD-ul (cum verifici că ai terminat), nu numele metodei și nici ce returnează. Alegerea între `void`,
`bool` și un obiect e jumătate din exercițiu.

---

## Cum verifici că ai terminat un folder (DoD)

1. Proiectul **compilează** (`Build`, F6) — înainte de orice commit.
2. `Main` are **două linii**: creezi View-ul și chemi `Play()`.
3. În `View` nu există **niciun `for` care caută** ceva în listă (unul care doar afișează tot e în regulă).
4. În `Service` nu există **niciun `Console.`**.
5. În `Model` nu există **niciun `Console.`** (`ContBancar.cs` încalcă asta acum — vezi C2).
6. Meniul are o opțiune pentru **fiecare** metodă publică din service, plus `0` de ieșire.
7. Rulezi **fiecare ramură**, nu doar una: găsit / negăsit / cazul special (ocupat, deja adoptat,
   sold out), plus o tastă care nu e în meniu.

Punctul 7 e regula din review-ul trecut. B2 stătea la vedere, dar căutai `"Ana"` — un animal
care nu există în listă — deci ramura greșită nu s-a executat niciodată.

---

## Nu te speria de warning-urile galbene

După ce am șters exercițiile vechi, Visual Studio o să-ți arate **vreo 56 de warning-uri**, mai ales:

```
warning CS0649: Field 'Produs.pret' is never assigned to, and will always have its default value 0
```

Sunt **warning-uri, nu erori** — proiectul compilează și rulează. Compilatorul îți spune adevărul:
în momentul ăsta nimic din proiect nu pune vreo valoare în `Produs.pret`, pentru că acel cod era
în exercițiile șterse.

Dispar singure pe măsură ce scrii View-urile: prima dată când scrii `produs.pret = ...` în
`ProdusView.Adaugare()`, warning-ul pentru `pret` se stinge. Le poți folosi ca listă de lucru —
cât timp mai vezi `CS0649` pentru un câmp, înseamnă că nicio aplicație nu-l completează încă.

**Erorile (roșu) se repară imediat. Warning-urile (galben) se citesc.** Diferența asta contează:
`CS0649` de mai sus a fost tot timpul acolo și-ți spunea ceva adevărat despre cod.

---

## Capcană pe Windows: namespace-ul

Toate fișierele din proiect au același `namespace structuri`, chiar dacă sunt în foldere diferite.
De-asta clasele se văd între ele fără niciun `using` — folderele organizează **fișierele**,
nu au legătură cu namespace-urile.

Când adaugi o clasă nouă într-un folder, **Visual Studio scrie automat**:

```csharp
namespace structuri.Produse    <-- GREȘIT pentru proiectul asta
```

Șterge partea de după punct, ca să rămână `namespace structuri`. Altfel clasa nouă nu va fi
văzută de restul proiectului, iar erorile („nu există în context") n-o să-ți spună de ce.

---

## Ce NU facem încă

Interfețe (`IStudentService`), proprietăți (`get`/`set`), moștenire, LINQ, bază de date.
Toate vin după. Acum se învață un singur lucru: **cine cu ce se ocupă**.
