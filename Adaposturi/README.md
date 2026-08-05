# Adaposturi — exerciții

Aplicația: evidența unui adăpost de animale. Modelul are `nume`, `specie`, `adoptat`.

> **Notă de nume:** clasa se cheamă `Adapost`, dar un obiect e un **animal**, nu un adăpost.
> Folderul (colecția) e adăpostul. Redenumirea clasei în `Animal` e unul dintre exercițiile de mai jos.

**Fără indicii.** `AdapostService.cs` și `AdapostView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
Singurul exemplu din proiect e `Studenti/`: uită-te acolo pentru **formă**, nu pentru soluție.
Nu-ți spun nici numele metodelor, nici ce returnează — alegerea între `void`, `bool` și un obiect
e jumătate din exercițiu.

**Reguli valabile la toate:**

- `Program.cs` — două linii: creezi View-ul și chemi `Play()`
- `View` — meniul, întrebările, mesajele; **nicio** căutare cu `for` în listă
- `Service` — niciun `Console.`
- `Model` — niciun `Console.`
- Build (F6) verde **înainte** de commit, și rulezi **fiecare** ramură

---

## Nivel 0 — meniul

| # | Cerință | DoD |
|---|---|---|
| A0a | `Main` are **două linii**: creezi `AdapostView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| A0 | Meniu cu opțiunile aplicației (vezi animalele / adaugă / adoptă / caută) + `0. Iesire`. | Adopți un animal, meniul reapare, listezi și vezi schimbarea. Tastezi 0 → programul se termină. |
| A0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

## Nivel 1 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| A1 | Adaugi un animal nou, cu validare (nume și specie nevide). | Animal fără specie → respins. |
| A2 | Ștergi un animal (a plecat definitiv). | A doua ștergere a aceluiași animal eșuează, lista nu se strică. |
| A3 | Corectezi specia unui animal introdus greșit. | Se schimbă în listă. Nume inexistent → mesaj. |
| A4 | Redenumești clasa `Adapost` în `Animal` (și fișierul odată cu ea). | Proiectul compilează după redenumire, în toate locurile care foloseau numele vechi. Folosește Rename din Visual Studio (F2), nu căutare-și-înlocuire manuală. |

## Nivel 2 — adopții

| # | Cerință | DoD |
|---|---|---|
| A5 | Adopți un animal. | Trei rezultate distincte: nu e la adăpost / era deja adoptat / tocmai l-ai adoptat. Rulezi de două ori pe același animal și primești mesaje **diferite**. Ăsta e B2 din `CODE_REVIEW_3.md` — condiția care era pe dos. |
| A6 | Un animal adoptat se întoarce la adăpost. | Adopți, îl întorci, îl adopți din nou — toate trei merg, cu mesajele corecte. |
| A7 | Două animale cu același nume, specii diferite (câinele Max și pisica Max). | Decizi: ori interzici numele duplicat la adăugare, ori căutarea cere **nume + specie**. Orice alegi, adopția lovește animalul corect — verifică rulând exact cazul ăsta. |

## Nivel 3 — rapoarte

| # | Cerință | DoD |
|---|---|---|
| A8 | Toate animalele disponibile pentru adopție. | Lista returnată e goală, nu `null`, când toate sunt adoptate. |
| A9 | Toate animalele dintr-o specie dată. | Specie inexistentă → listă goală, fără crash. |
| A10 | Câte animale sunt la adăpost, câte adoptate, ce procent. | 4 animale, 1 adoptat → „1 din 4 (25%)". |
| A11 | Listarea grupată pe specii. | Câinii sub un titlu, pisicile sub altul. Gruparea o decide service-ul, titlurile le scrie View-ul. |

## Nivel 4 — cazuri limită

| # | Cerință | DoD |
|---|---|---|
| A12 | Toate opțiunile din meniu, pe un adăpost **gol**. | Listare, căutare, adopție, ștergere — niciun crash, mesaje care au sens. |
| A13 | Numele scris cu literă mare sau mică găsește același animal. | Cauți „max" și găsești „Max". (`Equals` face diferența între ele — caută singură cum se compară ignorând literele mari.) |
