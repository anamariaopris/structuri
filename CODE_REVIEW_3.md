# Code Review #3 — `structuri` (CRUD pe listă + Mini-aplicații 1–5)

**Pentru:** Ana · **Acoperă:** ex13–ex15, ExercitiiMetodeCrud8–12, mini-aplicațiile 1–5 · **Data:** 2026-08-05
**Commit:** `a6501ce` „Exercitii 1-5"

Codul **compilează** și l-am **rulat** — toate constatările de mai jos sunt verificate pe execuție reală, nu doar citite.

Tiparul „găsește în listă → decide → acționează" e prins: în toate cele 5 mini-aplicații ai
lista, variabila `gasit = null`, bucla de căutare și `if (gasit != null)`. Ăsta e scheletul, și e corect peste tot.

Ce se rupe e **pasul 3: decizia de după găsire**. Din 5 aplicații, 2 acționează greșit și 1 acționează degeaba.
Toate trei au aceeași cauză, așa că le tratez împreună la final.

---

## 🔴 Critice

### B1 — Cinema: rezervi biletul ÎNAINTE să verifici dacă mai e loc (`Program.cs:1519`)

```csharp
if (filme[i].titlu.Equals(numeFilmCautat))
{
    gasit = filme[i];
    gasit.locuriLibere = gasit.locuriLibere - 1;   // ← scăderea e AICI, în buclă
}
```

Scăderea se face în momentul în care găsești filmul. Verificarea `locuriLibere > 0` vine
abia după buclă — adică **după** ce ai scăzut deja locul.

Rulat cu `film1.locuriLibere = 1` (ultimul bilet):

```
Film indisponibil
```

…dar `locuriLibere` a ajuns `0`. Deci: clientul **nu** primește biletul, iar locul **e consumat oricum**.
Cu `locuriLibere = 0` de la început ajungi la `-1` — un cinema cu minus un loc liber.

Cerința din fișă e explicită: *„dacă îl găsești **și mai are locuri (`locuriLibere > 0`)** → scade 1"*.
Ordinea contează: **verifici, apoi modifici**. Într-o rezervare reală asta e diferența dintre
„n-am reușit să rezerv" și „n-am reușit să rezerv, dar ți-am luat locul".

### B2 — Adăpost: condiția e inversată (`Program.cs:1664`)

```csharp
if (gasesteanimal.adoptat)
{
    gasesteanimal.adoptat = true;
    Console.WriteLine("Adoptat cu succes! ");
}
else
{
    Console.WriteLine("A fost deja adoptat");
}
```

Citește condiția cu voce tare: *„dacă animalul **este** adoptat → adoptă-l și zi «Adoptat cu succes»;
altfel → zi «A fost deja adoptat»"*. Exact pe dos față de propriile tale mesaje.

Rulat cu `cautaAnimal = "Max"` (Max are `adoptat = false`, e liber):

```
Animal gasit : Max
A fost deja adoptat
```

Un animal neadoptat e raportat ca adoptat, și nimeni nu-l poate adopta vreodată.
Bug-ul nu s-a văzut pentru că ai căutat `"Ana"` (`Program.cs:1637`) — nume care nu există în listă,
deci execuția intră mereu pe ramura „Nu este la adapost" și nu ajunge niciodată la `if`-ul greșit.

### B3 — Jocuri: cazul „L-ai terminat deja" nu poate apărea niciodată (`Program.cs:1585-1600`)

```csharp
if (identificat != null)
{
    identificat.terminat = true;
    Console.WriteLine("Joc marcat ca terminat");
}
else if (identificat == null) { ... }
```

Fișa cere **trei** cazuri: negăsit / găsit-și-neterminat / găsit-și-deja-terminat.
Tu ai doar două — verifici dacă jocul există, dar nu verifici niciodată câmpul `terminat`.
Rezultatul: dacă marchezi de două ori același joc, primești „Joc marcat ca terminat" de ambele ori.
Lipsește chiar poanta exercițiului: *„Îl cauți din nou → «L-ai terminat deja»"*.

`else if (identificat == null)` e și redundant — dacă n-ai intrat pe `!= null`, e obligatoriu `null`.
Simplu `else`.

### B4 — `PoateRetrage` returnează exact invers (`ContBancar.cs:42`)

```csharp
public bool PoateRetrage(double suma)
{
    if (suma > sold) { return true; }
    else { return false; }
}
```

„Pot retrage" înseamnă `suma <= sold`. Tu întorci `true` fix când **nu** ai bani.
Metoda e apelată doar din `exercitiimetodecrud3()`, care e comentat (`Program.cs:770-786`) —
de aia n-a explodat. Când decomentezi, cu `sold = 90` și `PoateRetrage(90)` vei primi „fonduri insuficiente"
pentru o retragere perfect validă.

### B5 — ex7: reducerea tot nu se face (`Program.cs:292-296`) — **rămas din review-ul #2**

Rulat acum:

```
laptop : 1000
telefon : 2000.5
Pret dupa scadere
laptop : 1000
telefon : 1000     ← prețul lui laptop, afișat pentru telefon
```

Ambele probleme semnalate în #2 sunt încă acolo: **lipsește scăderea efectivă** și linia 296
afișează `x.pret` în loc de `y.pret`.

✅ În schimb, cele două buguri de la **ex5 sunt reparate** — `z.pret * z.stoc` calculat corect,
`x.stoc = 1` a dispărut. Bine.

---

## Tabel before / after (doar criticele)

| # | Acum | Cum ar trebui |
|---|------|---------------|
| **B1** | <pre>if (filme[i].titlu.Equals(nume))<br/>{<br/>    gasit = filme[i];<br/>    gasit.locuriLibere -= 1;<br/>}<br/>...<br/>if (gasit != null && gasit.locuriLibere > 0)</pre> | <pre>if (filme[i].titlu.Equals(nume))<br/>{<br/>    gasit = filme[i];<br/>}<br/>...<br/>if (gasit != null)<br/>{<br/>    if (gasit.locuriLibere > 0)<br/>    {<br/>        gasit.locuriLibere = gasit.locuriLibere - 1;<br/>        Console.WriteLine("Bilet rezervat, au mai ramas " + gasit.locuriLibere);<br/>    }<br/>    else<br/>    {<br/>        Console.WriteLine("Sold out");<br/>    }<br/>}<br/>else<br/>{<br/>    Console.WriteLine("Filmul nu ruleaza");<br/>}</pre> |
| **B2** | <pre>if (gasesteanimal.adoptat)<br/>{<br/>    gasesteanimal.adoptat = true;<br/>    Console.WriteLine("Adoptat cu succes! ");<br/>}<br/>else<br/>{<br/>    Console.WriteLine("A fost deja adoptat");<br/>}</pre> | <pre>if (gasesteanimal.adoptat == false)<br/>{<br/>    gasesteanimal.adoptat = true;<br/>    Console.WriteLine("Adoptat cu succes");<br/>}<br/>else<br/>{<br/>    Console.WriteLine("A fost deja adoptat");<br/>}</pre> |
| **B3** | <pre>if (identificat != null)<br/>{<br/>    identificat.terminat = true;<br/>    Console.WriteLine("Joc marcat ca terminat");<br/>}<br/>else if (identificat == null) { ... }</pre> | <pre>if (identificat != null)<br/>{<br/>    if (identificat.terminat == false)<br/>    {<br/>        identificat.terminat = true;<br/>        Console.WriteLine("Marcat ca terminat");<br/>    }<br/>    else<br/>    {<br/>        Console.WriteLine("L-ai terminat deja");<br/>    }<br/>}<br/>else<br/>{<br/>    Console.WriteLine("Nu e in colectie");<br/>}</pre> |
| **B4** | <pre>if (suma > sold) { return true; }<br/>else { return false; }</pre> | <pre>return suma > 0 && suma <= sold;</pre> |
| **B5** | <pre>Console.WriteLine("Pret dupa scadere");<br/>Console.WriteLine(x.nume + " : " + x.pret);<br/>Console.WriteLine(y.nume + " : " + x.pret);</pre> | <pre>x.pret = x.pret - 10;<br/>y.pret = y.pret - 10;<br/><br/>Console.WriteLine("Pret dupa scadere");<br/>Console.WriteLine(x.nume + " : " + x.pret);<br/>Console.WriteLine(y.nume + " : " + y.pret);</pre> |

---

## 🟡 Importante

| # | Loc | Ce e |
|---|-----|------|
| **M1** | `Program.cs:1049` | `produse.RemoveAt(i)` într-un `for` crescător. Acum merge (ai un singur „baterie2", ultimul din listă), dar tiparul e greșit: după `RemoveAt(i)`, tot ce urma se mută cu o poziție în stânga, iar `i++` sare peste elementul care tocmai a luat locul celui șters. Cu două elemente de șters lipite unul de altul, al doilea **supraviețuiește**. Fie mergi invers (`for (int i = produse.Count - 1; i >= 0; i--)`), fie reții obiectul în buclă și faci `produse.Remove(gasit)` **după** buclă — cum ai făcut, de altfel, în blocul comentat de la ex15. |
| **M2** | `Program.cs:1466-1479` (Pizza) | `if (gasita.disponibila) { gasita.disponibila = true; ... }` — atribuirea nu face nimic (era deja `true`). Fișa nu-ți cere să modifici pizza aici; e o linie moartă, copiată din tiparul „acționează pe obiect". La pizzerie **doar citești**, ca la playlist. |
| **M3** | `Program.cs:1454`, `1637` | Ai testat un singur scenariu per aplicație, și fix pe ramura care nu execută nimic: `cautaPizza = "Hawaii"` (nu există) și `cautaAnimal = "Ana"` (nu există). De-asta B2 a trecut neobservat. **Regulă:** rulează fiecare exercițiu de câte ori are ramuri — la Adăpost de 3 ori: un animal liber, același animal a doua oară, un nume inexistent. Dacă o ramură n-a fost rulată niciodată, n-o poți considera scrisă. |
| **M4** | `Program.cs:706` | `Console.WriteLine("... ; " + ct++)` — afișează corect (post-incrementul întoarce valoarea veche), dar incrementezi un contor care nu mai e folosit niciodată. Într-un `WriteLine` pui `ct`, nu `ct++`. |
| **M5** | `Program.cs:1606-1679` | Clasa se numește `Adapost`, dar obiectele sunt animale (`nume`, `specie`, `adoptat`) — fișa cerea `Animal`. `Adapost adapost1 = new Adapost(); adapost1.specie = "caine";` se citește ca „adăpostul de specie câine". Clasa se numește după **ce e obiectul**, nu după locul unde stă. Lista e adăpostul. |
| **M6** | `Program.cs:152` (ex3) — **din review #1** | `(x.age + y.age + z.age) / 3` — toate sunt `int`, deci împărțire întreagă. Acum vârstele sunt 40/30/20 → 90/3 = 30 fix, așa că nu se vede. Schimbă o vârstă în 41 și media rămâne `30` în loc de `30.33`. Fixul e `/ 3.0`. |
| **M7** | `Produs.cs:15-16` | `pretNou` și `procent` nu sunt folosite nicăieri (compilatorul dă `warning CS0649`). În ex14/ex15 setezi `x.procent = 5` pe fiecare produs, dar reducerea o aplici cu variabila locală `double procent = 10` (`Program.cs:1222`) — deci câmpul de pe obiect e ignorat complet. Ori folosești `produse[i].AplicaReducere(produse[i].procent)`, ori scoți câmpul. |
| **M8** | `Program.cs:1359-1426` (ex15) | Partea de editare + ștergere e comentată — exercițiul e făcut pe jumătate. Când o decomentezi, atenție: cauți în `prCautat` (linia 1401) dar ștergi `produsCautat` (linia 1411) — variabila din căutarea anterioară. E același tipar de copy-paste ca la B5. |

---

## 🟢 Cleanups

| # | Loc | Ce |
|---|-----|-----|
| **C1** | `Fiilm.cs` | Numele fișierului e scris greșit și nu corespunde clasei (`Film`). Redenumește-l `Film.cs`. |
| **C2** | Toate buclele de căutare | Nu ai `break` după ce ai găsit obiectul — parcurgi lista până la capăt degeaba. La ex13/Pizza/Playlist e doar risipă; la **Cinema e periculos**, pentru că dacă apar două filme cu același titlu ai scădea locul de două ori. `break;` după `gasit = lista[i];`. |
| **C3** | `Produs.cs:24-26` | Încă `"Nume " + nume` fără `:` → „Nume produs1". Semnalat în #2. Un `$"Nume: {nume}"` rezolvă. |
| **C4** | `Program.cs:1329`, `1339` | La ex15, când respingi un produs afișezi `y.nume + " nu respecta validarea"` — dar `y.nume` e chiar `""`, deci mesajul iese fără subiect: „ nu respecta validarea listei". Când motivul respingerii e numele lipsă, mesajul trebuie să spună asta („Produs fara nume — respins"). |
| **C5** | `Program.cs:3-11` | `using System.Xml;`, `System.Runtime.Intrinsics.X86`, `JSType`, `X509Certificates`… — adăugate automat de Visual Studio, niciunul folosit. |
| **C6** | `Produs.cs:55-56` | Comentariul *„variabila reducere de fapt ia valoarea din variabila procent, AplicaReducere(procent) → aici procent nu există de fapt"* — vezi Q3, merită lămurit, e o confuzie utilă. |

---

## ✅ Corecte, fără obiecții

- **Exercitiul5Playlist** — cazul curat al tiparului: găsești, citești câmpuri, afișezi. Perfect.
- **Exercitiul13** — căutare user în listă + `Login(usr, pass)` + trei ramuri (găsit/parolă greșită/inexistent). Corect, verificat: „Autentificare reusita".
- **Exercitiul14** și **ExercitiuRecapitulare14** — total valoare stoc prin metodă (`ValoareStoc()`), apoi reducere pe fiecare obiect din listă. Corect. Comentariul tău de la linia 1272 („`produse[i]` → doar un produs oarecare din lista") arată că ai înțeles ce e indexul.
- **ExercitiiMetodeCrud8** — validare înainte de `Add`. Corect.
- **ExercitiiMetodeCrud9/10/12** — filtrare, editare prin listă, numărare + afișare. Corecte.
- **ExercitiiMetodeCrud10** — demonstrezi chiar tu că `produse[i].pret = 1234` schimbă și `abc.pret`, pentru că e **același obiect**. Ăsta e conceptul de referință, prins corect.
- **`ContBancar.Depune` / `Retrage`** — validările sunt corecte (`suma > 0`, `suma <= sold`).
- **Comentariile tale** din Adăpost (liniile 1647-1649, simularea pas cu pas a buclei) și din Joc (1576-1577, „devine referință către `jocuri[i]`") — exact așa se citește o buclă. Ține obiceiul.

---

## Firul roșu: pasul 3 al tiparului

Toate cele 5 mini-aplicații au aceeași structură, iar tu ai prins-o. Se rupe însă **mereu în același loc**:

```
1. lista            ✅ corect peste tot
2. cauți            ✅ corect peste tot
3. gasit != null ?  ✅ corect peste tot
4. DECIZIA pe obiectul găsit   ← aici cad B1, B2, B3 și M2
```

Pasul 4 are, la exercițiile cu 3 cazuri, o formă fixă:

```csharp
if (gasit != null)
{
    if (/* obiectul e în starea care permite acțiunea */)
    {
        /* modifici starea */
        /* mesaj de succes */
    }
    else
    {
        /* mesaj „nu se poate / deja făcut" */
    }
}
else
{
    /* mesaj „nu există" */
}
```

Două reguli care ies din B1 și B2:

1. **Verifici, apoi modifici** — niciodată invers. Modificarea e ultimul lucru, după ce ai decis că se poate (B1).
2. **Condiția din `if` trebuie să se potrivească cu mesajul din interiorul lui.** Dacă în `if` scrie „e adoptat" iar înăuntru scrie „Adoptat cu succes", una din ele e greșită (B2). Citește-le împreună, cu voce tare.

---

## Q&A — verifică-ți înțelegerea

**Q1.** La Cinema, cu `locuriLibere = 1`, programul afișează „Film indisponibil", dar după rulare
`locuriLibere` e `0`. Explică în cuvintele tale de ce se pierde locul, deși rezervarea a eșuat.
Ce ordine a operațiilor ar fi împiedicat asta?

**Q2.** La Adăpost, ce se afișează dacă rulezi `Exercitiul4Adapost()` cu `cautaAnimal = "Max"`?
Dar dacă în plus schimbi `adapost1.adoptat = true`? Scrie ambele răspunsuri **înainte** să rulezi,
apoi rulează și compară. (Dacă cele două ies identice, ai găsit singură bug-ul.)

**Q3.** În `Produs.AplicaReducere(double reducere)` ai scris în comentariu că „`AplicaReducere(procent)`
→ aici `procent` nu există de fapt". Ai dreptate pe jumătate. Explică: de unde își ia `reducere`
valoarea la execuție, și ce legătură are numele variabilei din `Main` cu numele parametrului din metodă?
Ce s-ar întâmpla dacă în `Main` ai numi variabila `x` în loc de `procent` — ar mai merge metoda?

**Q4.** La `ExercitiiMetodeCrud11` ștergi cu `RemoveAt(i)` din interiorul buclei. Adaugă un al doilea
produs numit tot `"baterie2"`, **imediat lângă** primul, și rulează. Câte se șterg? De ce?

---

## Pe scurt

Scheletul e stăpânit — 5 din 5 aplicații au lista, căutarea și `gasit != null` corect scrise, iar
Playlist și ex13 sunt complet corecte. Ce rămâne de reparat e **decizia de după găsire**:
B1 (Cinema — scazi înainte să verifici), B2 (Adăpost — condiție inversată), B3 (Jocuri — lipsește
al treilea caz), plus B4 (`PoateRetrage`) și B5 (ex7, rămas din review-ul #2).

Și obiceiul care le-ar fi prins pe toate: **rulează fiecare ramură, nu doar una**. B2 stătea la vedere,
dar căutai un animal care nu există.
