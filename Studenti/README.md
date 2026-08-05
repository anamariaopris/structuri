# Studenti — exerciții

Aplicația: un catalog. Aici `StudentService.cs` și `StudentView.cs` sunt **deja scrise** — sunt etalonul pe care îl copiezi ca formă în celelalte foldere. Exercițiile de mai jos le adaugi peste el.

**Fără indicii.** Nu-ți spun nici numele metodei, nici ce returnează — decizi tu. Faptul că alegi între
`void`, `bool` și un obiect e jumătate din exercițiu.

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
| S0a | `Main` are **două linii**: creezi `StudentView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| S0 | Meniu cu opțiunile de bază (adaugă / listează / caută / șterge) + `0. Iesire`, care reapare după fiecare acțiune. | Tastezi 2, vezi catalogul, meniul reapare singur. Tastezi 0 → programul se termină. |
| S0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

---

## Nivel 1 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| S1 | Modifici media unui student căutat după nume. | Cauți „Mihai", îi pui 8.5, afișezi lista: apare 8.5. Cauți „Radu" (inexistent): niciun crash, mesaj din View. |
| S2 | Ștergi un student după nume. | Ștergi „Ana" → lista are un element mai puțin. Ștergi „Ana" a doua oară → mesaj că nu există, lista neschimbată. |
| S3 | Nu accepți doi studenți cu același nume. | Adaugi „Ana" de două ori → lista are **un** singur „Ana", iar a doua adăugare spune de ce a fost respinsă. |
| S4 | Nu accepți o medie în afara intervalului 1–10. | Adaugi un student cu media 15 → respins. Cu media 10 → acceptat. |

## Nivel 2 — rapoarte peste listă

| # | Cerință | DoD |
|---|---|---|
| S5 | Media întregii clase. | 3 studenți cu 9.5, 4.2 și 7 → 6.9 (nu 6). |
| S6 | Studentul cu cea mai mare medie. | Îl returnezi ca **obiect**, nu îl afișezi din service. |
| S7 | Câți studenți au promovat (medie ≥ 5) și câți au picat. | 3 studenți cu 9.5, 4.2, 7 → 2 promovați, 1 picat. |
| S8 | Toți studenții cu media peste un prag primit ca parametru. | Prag 7 → lista returnată are 2 elemente; pragul 10 → lista returnată e goală (nu `null`). |

## Nivel 3 — cazuri limită și afișare

| # | Cerință | DoD |
|---|---|---|
| S9 | Media clasei pe un catalog **gol**. | Nu crapă și nu afișează `NaN`. Decizi tu ce înseamnă „medie fără studenți" și View-ul spune asta în cuvinte. |
| S10 | Ordonezi catalogul descrescător după medie. | Fără LINQ, fără `Sort()` — cu bucle. După ordonare, primul din listă e cel cu media cea mai mare. |
| S11 | Afișezi catalogul numerotat, cu „promovat"/„picat" pe fiecare rând. | `1. Ana - 9.5 - promovat`. Numerotarea e treaba View-ului, nu a service-ului. |
| S12 | Autentifici un student (nume + parolă). | Folosești metoda `IsValidCredentials` care există deja pe model — service-ul o cheamă, nu rescrie verificarea. Trei rezultate: reușit / parolă greșită / nume inexistent. |

## Nivel 4 — meniul, dus până la capăt

| # | Cerință | DoD |
|---|---|---|
| S13 | Programul nu crapă dacă la „Medie:" tastez `abc`. | Tastezi `abc` → mesaj că nu e număr, meniul reapare, studentul **nu** e adăugat. (`double.Parse` crapă. Caută singură ce se folosește în locul lui.) |
| S14 | Meniul are o opțiune pentru **fiecare** metodă publică din service. | Numeri metodele publice din `StudentService.cs` și opțiunile din meniu: același număr, plus `0`. |
| S15 | Ecranul se curăță înainte de reafișarea meniului, dar rezultatul acțiunii rămâne vizibil până apeși Enter. | Cauți un student, îi vezi media, apeși Enter, abia atunci ecranul se curăță și meniul reapare. |
| S16 | Un submeniu: opțiunea „5. Rapoarte" deschide un al doilea meniu (media clasei, promovați, top). | Din submeniu te poți întoarce în meniul principal fără să închizi programul. |
