# Filme — exerciții

Aplicația: casa de bilete a unui cinema. Modelul `Film.cs` are `titlu` și `locuriLibere`.

**Fără indicii.** `FilmService.cs` și `FilmView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
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
| F0a | `Main` are **două linii**: creezi `FilmView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| F0 | Meniu cu opțiunile aplicației (vezi programul / rezervă / anulează / adaugă film) + `0. Iesire`. | Rezervi, meniul reapare, listezi și vezi că locurile au scăzut. Tastezi 0 → programul se termină. |
| F0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

## Nivel 1 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| F1 | Adaugi un film nou în program, cu validare (titlu nevid, locuri ≥ 0). | Film cu −5 locuri → respins. |
| F2 | Scoți un film din program. | A doua ștergere a aceluiași film eșuează, programul nu se strică. |
| F3 | Modifici numărul de locuri al unui film (sala s-a schimbat). | Locurile se schimbă în listă. Titlu inexistent → mesaj. |
| F4 | Nu accepți două filme cu același titlu. | Altfel rezervarea nu știe pe care din ele o scade. |

## Nivel 2 — rezervări

| # | Cerință | DoD |
|---|---|---|
| F5 | Rezervi **un** loc la un film. | Verifici `locuriLibere > 0` **înainte** să scazi. Ultimul bilet (1 loc) se rezervă cu succes și rămân 0. Al doilea om primește „Sold out" **și locurile rămân 0, nu −1**. Ăsta e B1 din `CODE_REVIEW_3.md` — aici îl repari o dată pentru totdeauna. |
| F6 | Anulezi o rezervare (locul se întoarce). | Rezervi, anulezi, numărul de locuri e cel de la început. |
| F7 | Rezervi **mai multe** locuri deodată (o familie de 4). | Ceri 4 când sunt 2 libere → rezervarea eșuează **și nu se scade niciun loc**. Ori toate, ori niciunul. Rulează exact acest caz și verifică lista după. |
| F8 | Un film „sold out" nu mai apare la rezervare, dar rămâne în program. | Cu 0 locuri, filmul apare la listare marcat „SOLD OUT" și e refuzat la rezervare. |

## Nivel 3 — rapoarte

| # | Cerință | DoD |
|---|---|---|
| F9 | Toate filmele care mai au locuri. | Lista returnată e goală, nu `null`, când toate sunt pline. |
| F10 | Totalul locurilor libere din tot cinematograful. | 3 filme cu 5, 0 și 8 → 13. |
| F11 | Filmul cu cele mai puține locuri rămase. | Returnat ca **obiect**. Pe listă goală nu crapă. |
| F12 | Adaugi în model un câmp `locuriTotale` și afișezi gradul de ocupare. | `Dune: 3/10 libere (70% ocupat)`. Calculul e în service sau pe model, formatarea în View. |

## Nivel 4 — cazuri limită

| # | Cerință | DoD |
|---|---|---|
| F13 | Rezervi un număr negativ sau zero de locuri. | Respins, locurile neschimbate. |
| F14 | Programul nu crapă dacă la „Cate locuri:" tastez `abc`. | Mesaj că nu e număr, nicio rezervare, meniul reapare. |
| F15 | Rezervi dintr-un program gol. | Fără crash, mesaj corect. Rulează **înainte** să adaugi vreun film. |
