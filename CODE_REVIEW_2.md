# Code Review #2 — `structuri` (Clase, Obiecte, Liste + `for`)

**Pentru:** Ana · **Acoperă:** ex7–ex9 (clase) + secțiunea de liste · **Data:** 2026-07-08

Partea de **liste cu `for`** e foarte bună — ai prins tiparul complet: construiești
obiecte, le pui în `List<Produs>` / `List<Student>`, parcurgi cu
`for (int i = 0; i < lista.Count; i++)` și lucrezi pe `lista[i]`. Suma, media,
maximul, minimul, numărarea și filtrarea sunt toate corecte. Ăsta e exact scheletul
pe care se construiește tot ce urmează.

Mai jos ai **1 bug real** (la ex7) și câteva lucruri mici. La final, un reminder:
cele 2 buguri din review-ul precedent sunt încă nereparate.

---

## 🔴 Bug — ex7: reducerea de preț nu se face (și un typo de afișare)

```csharp
//2.scade 10 din pretul fiecaruia (produs.pret = produs.pret - 10)

Console.WriteLine("Pret dupa scadere");
Console.WriteLine(x.nume + " : " + x.pret);
Console.WriteLine(y.nume + " : " + x.pret);   // ← x.pret în loc de y.pret
```

Două probleme:

1. **Lipsește chiar scăderea.** Ai scris în comentariu ce trebuie făcut
   (`produs.pret = produs.pret - 10`), dar codul nu o execută. Afișezi „Pret dupa
   scadere”, însă prețurile sunt neschimbate. Ăsta e miezul exercițiului — să
   **modifici starea obiectului** și apoi să reafișezi:
   ```csharp
   x.pret = x.pret - 10;   // sau x.pret -= 10;
   y.pret = y.pret - 10;
   ```

2. **Typo copy-paste** pe ultima linie: afișezi `x.pret` pentru `y`. Ar trebui
   `y.pret`. E exact genul de greșeală pe care ex7 vrea să te învețe s-o prinzi —
   de aia se cere reafișarea după modificare.

---

## 🟡 Lucruri mici (nu buguri)

| Loc | Observație | Sugestie |
|-----|-----------|----------|
| `Produs.Descriere()` | `"Nume" + nume` → iese lipit: „Numelaptop” | pune spațiu/`: ` → `"Nume: " + nume` sau interpolare `$"Nume: {nume}"` |
| `Student.Descriere()` | la fel, `"Nume "` fără `:` | mic cosmetic, aceeași idee |
| `ex1Liste` | obiectul `x` (linia cu „laptop”) e creat dar nu intră în listă | folosești doar `x1`–`x4`; șterge `x` ca să nu deruteze |
| `exercitiul3PretulMediu` | `(double)(suma / produse.Count)` | cast-ul e inutil aici — `suma` e deja `double`, deci împărțirea e corectă oricum |
| `Program.cs` | `Main` rulează doar `exdercitiul7ProduseleDinOferta()` | normal la testat pe rând; comută apelul ca să le vezi și pe celelalte |
| `using`-uri auto (`Intrinsics.X86`, `JSType`, `CodeAnalysis`…) | inofensive, le poți șterge pentru curățenie |

---

## ✅ Corecte, fără obiecții

- **ex8** — clasa `Student` nouă, `medie >= 5`, câte un if/else per student. Corect.
- **ex9** — eticheta produsului construită cu `+` și `\n` într-un singur `WriteLine`. Corect.
- **ex1Liste / ex2Liste** — `List<Produs>` / `List<Student>` + `for` cu `.Count`. Corect.
- **exercitiul2Sumapreturilor** — acumulator `suma += produse[i].pret`. Corect.
- **exercitiul3PretulMediu** — sumă / `Count`. Corect (cast redundant, atât).
- **exercitiul4CelMaiScumpProdus** — `maxim = produse[0]`, buclă de la `i = 1`, `>`. Corect.
- **exercitiul5CelMaiIeftinProdus** — pornești de la un element și cauți cu `<=`. Corect.
- **exercitiu6CateProduseInOferta** — contor cu `if (produse[i].inOferta)`. Corect.
- **exdercitiul7ProduseleDinOferta** — filtrare + afișare. Corect.

---

## ⚠️ Reminder — buguri din review-ul #1 încă nereparate

Din `CODE_REVIEW.md` (2026-07-01), acestea sunt tot deschise:

| Ex | Bug | Linie |
|----|-----|-------|
| ex3 | `/ 3` în loc de `/ 3.0` → media iese `35` în loc de `35.33…` (împărțire întreagă) | `Program.cs:145` |
| ex5 | `x.stoc = 1;` în loc de `y.stoc = 1;` → suprascrii stocul greșit | `Program.cs:207` |
| ex5 | `12.5 * 10` hardcodat în loc de `z.pret * z.stoc` | `Program.cs:220` |

Repară-le înainte de a merge mai departe — mai ales ex3, `int` vs `double` e conceptul
care revine peste tot (l-ai folosit corect la liste, deci îl știi).

---

## Pe scurt

Progres foarte bun pe liste — partea grea (parcurgere + acumulator + căutare max/min)
e stăpânită. De reparat: **ex7** (scăderea efectivă + typo `x.pret`→`y.pret`) și cele
**3 rânduri rămase din review-ul #1**. Restul e curat.
