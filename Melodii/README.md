# Melodii — exerciții

Aplicația: un playlist. Modelul `Melodie.cs` are `titlu`, `artist`, `durata` (în secunde).

**Fără indicii.** `MelodieService.cs` și `MelodieView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
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
| M0a | `Main` are **două linii**: creezi `MelodieView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| M0 | Meniu cu opțiunile aplicației (vezi playlistul / adaugă / caută / șterge) + `0. Iesire`. | Adaugi o melodie, meniul reapare, listezi și o vezi. Tastezi 0 → programul se termină. |
| M0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

## Nivel 1 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| M1 | Adaugi o melodie, cu validare (titlu și artist nevide, durată > 0). | Durată 0 → respinsă, playlistul neschimbat. |
| M2 | Cauți o melodie după titlu și afișezi artistul și durata. | Titlu inexistent → mesaj, fără crash. |
| M3 | Scoți o melodie din playlist. | A doua ștergere a aceleiași melodii eșuează, playlistul nu se strică. |
| M4 | Nu accepți aceeași melodie de două ori (același titlu **și** același artist). | Două melodii diferite cu același titlu, de artiști diferiți, sunt permise. |

## Nivel 2 — rapoarte

| # | Cerință | DoD |
|---|---|---|
| M5 | Durata totală a playlistului, afișată ca `mm:ss`. | 125 secunde → `2:05`, nu `2:5` și nu `2.08`. Service-ul dă secundele, **View-ul face formatarea**. |
| M6 | Cea mai lungă și cea mai scurtă melodie. | Returnate ca **obiecte**. Pe playlist gol nu crapă. |
| M7 | Toate melodiile unui artist. | Artist inexistent → listă goală, nu `null`. |
| M8 | Lista artiștilor distincti din playlist. | 4 melodii de Inna, Inna, Delia, Feli → trei artiști, nu patru. Fără LINQ. |

## Nivel 3 — playlist adevărat

| # | Cerință | DoD |
|---|---|---|
| M9 | Ordonezi playlistul după durată, crescător. | Fără LINQ, fără `Sort()` — cu bucle. După ordonare, prima melodie e cea mai scurtă. |
| M10 | „Următoarea melodie": dai un titlu și primești melodia care vine după el în playlist. | Pentru ultima melodie din listă → se întoarce la prima. Rulează exact cazul ăsta. |
| M11 | Muți o melodie mai sus în playlist (schimbi ordinea). | Muți prima melodie mai sus → nu se întâmplă nimic, fără crash. |
| M12 | Playlistul afișat numerotat, cu durata fiecărei melodii în `mm:ss` și totalul pe ultimul rând. | `1. AAA - Inna - 2:00`. Numerotarea și formatarea sunt treaba View-ului. |

## Nivel 4 — cazuri limită

| # | Cerință | DoD |
|---|---|---|
| M13 | Programul nu crapă dacă la „Durata:" tastez `abc`. | Mesaj că nu e număr, melodia **nu** e adăugată, meniul reapare. |
| M14 | Toate opțiunile din meniu, pe un playlist **gol**. | Durata totală, cea mai lungă, „următoarea" — niciun crash, mesaje care au sens. |
