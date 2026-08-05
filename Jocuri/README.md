# Jocuri — exerciții

Aplicația: colecția ta de jocuri. Modelul `Joc.cs` are `nume`, `platforma`, `terminat`.

**Fără indicii.** `JocService.cs` și `JocView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
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
| J0a | `Main` are **două linii**: creezi `JocView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| J0 | Meniu cu opțiunile aplicației (vezi colecția / adaugă joc / marchează terminat / șterge) + `0. Iesire`. | Marchezi un joc, meniul reapare, listezi și vezi schimbarea. Tastezi 0 → programul se termină. |
| J0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

## Nivel 1 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| J1 | Adaugi un joc, cu validare (nume și platformă nevide). | Joc fără nume → respins, colecția neschimbată. |
| J2 | Ștergi un joc din colecție. | A doua ștergere a aceluiași joc eșuează, colecția nu se strică. |
| J3 | Nu accepți același joc de două ori (același nume **și** aceeași platformă). | „gta" pe PC și „gta" pe PS5 sunt două intrări valide. „gta" pe PC de două ori — nu. |
| J4 | Muți un joc pe altă platformă. | Platforma se schimbă în listă, nu doar în variabila locală. |

## Nivel 2 — starea jocului

| # | Cerință | DoD |
|---|---|---|
| J5 | Marchezi un joc ca terminat. | Trei rezultate distincte: nu e în colecție / era deja terminat / tocmai l-ai marcat. Al doilea apel pe același joc **nu** mai spune „marcat cu succes". Ăsta e B3 din `CODE_REVIEW_3.md`. |
| J6 | Îl pui înapoi pe „neterminat" (o iei de la capăt). | Marchezi, apoi resetezi, apoi marchezi din nou — toate trei merg și mesajele sunt corecte de fiecare dată. |
| J7 | Marchezi terminate **toate** jocurile de pe o platformă. | 4 jocuri, 2 pe „PC" → doar alea două se schimbă. |

## Nivel 3 — rapoarte

| # | Cerință | DoD |
|---|---|---|
| J8 | Jocurile terminate și, separat, cele neterminate. | Ambele liste returnate goale, nu `null`, când nu e nimic de returnat. |
| J9 | Câte jocuri ai terminat din total și ce procent. | 4 jocuri, 1 terminat → „1 din 4 (25%)". |
| J10 | Toate jocurile de pe o platformă dată. | Platformă inexistentă → listă goală, nu crash. |
| J11 | Lista platformelor distincte din colecție. | 4 jocuri pe „PC", „PC", „PS5", „PC" → două platforme, nu patru. Fără LINQ. |

## Nivel 4 — cazuri limită

| # | Cerință | DoD |
|---|---|---|
| J12 | Procentul de jocuri terminate pe o colecție **goală**. | Nu crapă și nu afișează `NaN`. Decizi tu ce afișezi și View-ul o spune în cuvinte. |
| J13 | Colecția goală, la fiecare opțiune din meniu. | Listare, căutare, marcare, ștergere — toate patru pe colecția goală, fără niciun crash. |
