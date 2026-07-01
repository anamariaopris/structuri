# Code Review — `structuri` (Clase și Obiecte)

**Pentru:** Ana · **Rezolvate:** 6/10 (ex1–ex6) · **Data:** 2026-07-01

Felicitări — clasele `User` și `Produs` sunt corecte, iar structura cu câte o metodă
per exercițiu (`ex1()`, `ex2()`, …) e exact abordarea bună. Mai jos ai 2 buguri reale
și câteva lucruri mici de îngrijit.

---

## 🔴 Bug 1 — ex3: împărțire întreagă (media iese greșit)

```csharp
double sumamedie = (x.age + y.age + z.age) / 3;
```

`age` este `int`, deci `(43 + 30 + 33) / 3` se calculează **între numere întregi**:
`106 / 3 = 35` (partea zecimală se pierde). Abia rezultatul deja trunchiat ajunge
în `double`, așa că `.33…` e pierdut definitiv.

**De ce:** în C#, `int / int` dă tot un `int`. Ca să obții zecimale, măcar un operand
trebuie să fie `double`.

**Fix:**
```csharp
double sumamedie = (x.age + y.age + z.age) / 3.0;
```

Reține tiparul: `/ 3.0`, nu `/ 3`. Verifică: rezultatul corect e `35.33…`, nu `35`.

---

## 🔴 Bug 2 — ex5: typo copy-paste + valoare hardcodată

```csharp
y.nume = "bec";
y.pret = 10;
x.stoc = 1;        // ← ar trebui y.stoc = 1;
```

Ai setat din greșeală `x.stoc` în loc de `y.stoc`. Rezultatul: suprascrii stocul lui
`x`, iar `y.stoc` rămâne `0`. Bug-ul e „ascuns” pentru că suma prețurilor nu folosește
`stoc`, deci output-ul pare corect — dar datele obiectelor sunt greșite.

Și la bonus:
```csharp
double surub = 12.5 * 10;   // hardcodat
```

Merge doar pentru că valorile coincid. Ideea exercițiului e să folosești **câmpurile
obiectului**, ca să funcționeze chiar dacă schimbi prețul sau stocul:

```csharp
double valoareStoc = z.pret * z.stoc;
```

---

## 🟡 Lucruri mici (nu buguri)

| Loc | Observație | Sugestie |
|-----|-----------|----------|
| ex1 | afișezi `x.age` (vârsta) | cerința zicea *userul* → mai firesc `x.name` |
| ex2 | `"Useri activi" + contorActivi` | adaugă `: ` → `"Useri activi: "` |
| ex1 | compari cu `>` strict | la vârste egale cade pe `else` (ok la nivelul ăsta) |
| Program.cs | `Main` rulează doar `ex6()` | normal când testezi pe rând; comută apelul ca să le vezi pe toate |
| Program.cs | `using`-uri auto (`JSType`, `CodeAnalysis`…) | inofensive, le poți șterge pentru curățenie |

---

## ✅ Corecte, fără obiecții

- **ex4** — comparație `==` cu `&&`, if/else clar.
- **ex6** — câte un `if (produs.inOferta)` pentru fiecare, exact ca în indiciu.
- **Clasa `Produs`** — câmpuri corecte (`nume`, `pret`, `stoc`, `inOferta`).

---

## Rămân de făcut

| Ex | Cerință |
|----|---------|
| ex7 | Reducere de preț — modifici `pret` și reafișezi (starea obiectului) |
| ex8 | Student promovat — clasă nouă `Student`, `medie >= 5` |
| ex9 | Eticheta produsului — lipești câmpuri cu `+` într-un singur `WriteLine` |
| ex10 | Cel mai ieftin și cel mai scump — o căutare cu `<`, una cu `>` |

**Prioritate:** repară întâi Bug 1 (ex3) — e cel mai important de înțeles (`int` vs `double`).
