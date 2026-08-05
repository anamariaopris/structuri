# ConturiBancare — exerciții

Aplicația: ghișeul unei bănci. Modelul `ContBancar.cs` are `titular`, `sold` și metodele
`Depune`, `Retrage`, `PoateRetrage` — **deja scrise**.

> **Atenție, două lucruri sunt greșite în model și le repari tu, nu le ocolești:**
> `PoateRetrage` returnează exact invers (B4 din `CODE_REVIEW_3.md`), iar `Depune` și `Retrage`
> au `Console.WriteLine` **în model** — un model n-are voie să vorbească cu ecranul.

**Fără indicii.** `ContBancarService.cs` și `ContBancarView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
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
| C0a | `Main` are **două linii**: creezi `ContBancarView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| C0 | Meniu cu opțiunile ghișeului (deschide cont / vezi conturile / depune / retrage / sold) + `0. Iesire`. | Depui, meniul reapare, ceri soldul și vezi suma nouă. Tastezi 0 → programul se termină. |
| C0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

## Nivel 1 — curățenie în model

| # | Cerință | DoD |
|---|---|---|
| C1 | Repari `PoateRetrage`. | Cu sold 90, `PoateRetrage(90)` → adevărat; `PoateRetrage(91)` → fals. Rulează ambele. |
| C2 | Scoți `Console.WriteLine` din `Depune` și `Retrage`. | Modelul spune doar **dacă a reușit**; mesajul îl scrie View-ul. După modificare, `ContBancar.cs` nu mai conține cuvântul `Console`. |
| C3 | Meniul are o opțiune „pot retrage suma X?" care răspunde fără să miște banii. | Cu sold 90 întrebi de 90 → „da"; întrebi de 91 → „nu". După ambele întrebări soldul e tot 90. |

## Nivel 2 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| C4 | Deschizi un cont nou, cu validare (titular nevid, sold inițial ≥ 0). | Sold inițial negativ → respins. |
| C5 | Cauți un cont după titular. | Titular inexistent → mesaj, fără crash. |
| C6 | Închizi un cont. | A doua închidere a aceluiași cont eșuează. Decizi dacă un cont cu sold > 0 poate fi închis — și te ții de decizie. |
| C7 | Nu accepți două conturi cu același titular. | Altfel depunerea nu știe în care intră. |

## Nivel 3 — operațiuni

| # | Cerință | DoD |
|---|---|---|
| C8 | Depui o sumă într-un cont găsit după titular. | Sumă negativă sau 0 → respinsă, soldul neschimbat. |
| C9 | Retragi o sumă. | Ceri 200 dintr-un sold de 150 → refuzat **și soldul rămâne 150**. Ceri exact 150 → merge, soldul ajunge 0. |
| C10 | **Transfer** între două conturi. | Cel mai important din tot folderul: dacă retragerea din primul cont eșuează, în al doilea **nu intră nimic**. Rulezi transfer de 500 dintr-un cont cu 100 și verifici **ambele** solduri după: neschimbate. Ori se întâmplă tot, ori nimic. |
| C11 | Transfer către tine însuți. | Titular sursă = titular destinație → refuzat, soldul neatins (altfel îl poți dubla din greșeală). |

## Nivel 4 — istoric și rapoarte

| # | Cerință | DoD |
|---|---|---|
| C12 | Fiecare cont ține un istoric al operațiunilor (`List<string>` pe model). | După depunere + retragere + transfer, istoricul are 3 rânduri, în ordine. |
| C13 | Afișezi extrasul de cont: titular, sold, istoric. | Totul e formatat în View. Cont fără operațiuni → „Nicio operatiune". |
| C14 | Rapoarte: soldul total din bancă, contul cu cel mai mare sold, conturile goale. | Pe bancă goală nu crapă. |
| C15 | Programul nu crapă dacă la „Suma:" tastez `abc`. | Mesaj că nu e număr, nicio operațiune executată, meniul reapare. |
