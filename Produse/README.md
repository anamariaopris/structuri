# Produse — exerciții

Aplicația: stocul unui magazin. Modelul `Produs.cs` e gata și are deja `ValoareStoc()`, `IsInStoc()`,
`AplicaReducere()` — **service-ul le cheamă, nu le rescrie**.

**Fără indicii.** `ProdusService.cs` și `ProdusView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
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

Fiecare exercițiu de mai jos devine **o opțiune nouă în meniu**. `Play()` e un dispecer: fiecare tastă
cheamă o metodă scurtă care întreabă omul, cheamă service-ul și spune rezultatul.

| # | Cerință | DoD |
|---|---|---|
| P0a | `Main` are **două linii**: creezi `ProdusView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| P0 | Meniu cu opțiunile de bază (adaugă / listează / caută / modifică preț / șterge) + `0. Iesire`. | Tastezi 2, vezi stocul, meniul reapare singur. Tastezi 0 → programul se termină. |
| P0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

---

## Nivel 1 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| P1 | Modifici prețul unui produs căutat după nume. | Prețul se schimbă în listă, nu doar în variabila locală. Produs inexistent → mesaj, fără crash. |
| P2 | Ștergi un produs după nume. | Ștergi de două ori același produs: prima dată reușește, a doua oară nu. |
| P3 | Nu accepți două produse cu același nume. | Adaugi „baterie" de două ori → lista are una singură. (În exercițiile vechi aveai două produse „baterie", și editarea le lovea pe amândouă.) |
| P4 | Ștergi **toate** produsele fără stoc, dintr-o singură comandă. | Lista are 5 produse, 2 cu stoc 0 → după apel rămân 3. Atenție: e fix capcana M1 din review (ștergere în timp ce parcurgi). |

## Nivel 2 — operații de magazin

| # | Cerință | DoD |
|---|---|---|
| P5 | Vinzi o cantitate dintr-un produs. | Verifici stocul **înainte** să-l scazi. Ceri 10 bucăți când sunt 3 → vânzarea eșuează **și stocul rămâne 3**. Ăsta e B1 din review, pe alt domeniu. |
| P6 | Aprovizionezi un produs (adaugi la stoc). | Cantitate negativă → respinsă, stocul neschimbat. |
| P7 | Aplici o reducere la toate produsele deodată. | 3 produse, reducere 10% → toate trei au prețul mai mic. Reducere 0 → nimic nu se schimbă. |
| P8 | Aplici reducere doar produselor din ofertă. | Produsele cu `inOferta = false` ies cu prețul neatins. |

## Nivel 3 — rapoarte

| # | Cerință | DoD |
|---|---|---|
| P9 | Valoarea totală a stocului din magazin. | Folosești `ValoareStoc()` de pe model. 2 produse (10 lei × 3 buc, 5 lei × 2 buc) → 40. |
| P10 | Cel mai scump și cel mai ieftin produs. | Returnate ca **obiecte**. Pe listă goală nu crapă. |
| P11 | Toate produsele rămase fără stoc. | Lista returnată e goală, nu `null`, când toate au stoc. |
| P12 | Un raport afișat ca tabel aliniat: nume, preț, stoc, valoare stoc, iar pe ultimul rând totalul. | Tot ce ține de aliniere și de „ultimul rând" e în View. Service-ul dă doar cifre. |

## Nivel 4 — cazuri limită

| # | Cerință | DoD |
|---|---|---|
| P13 | Reducere de 100% și reducere negativă. | Prețul nu ajunge niciodată sub 0, iar o reducere negativă (care ar **crește** prețul) e respinsă. |
| P14 | Cauți un produs când lista e goală. | Fără crash, mesaj corect. Rulează asta **înainte** să adaugi ceva în listă. |
| P15 | Programul nu crapă dacă la „Pret:" tastez `abc`. | Mesaj că nu e număr, produsul **nu** e adăugat, meniul reapare. (`double.Parse` crapă — caută singură ce se folosește în locul lui.) |
| P16 | Meniul are o opțiune pentru fiecare metodă publică din service, iar rapoartele stau într-un **submeniu**. | Din submeniul „Rapoarte" te întorci în meniul principal fără să închizi programul. |
