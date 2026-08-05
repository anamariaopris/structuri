# Pizze — exerciții

Aplicația: meniul unei pizzerii. Modelul `Pizza.cs` are `nume`, `pret`, `disponibila`.

**Fără indicii.** `PizzaService.cs` și `PizzaView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
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

Atenție la o confuzie de cuvinte: **meniul aplicației** (ce taste apeși) nu e același lucru cu
**meniul pizzeriei** (lista de pizze). Primul e în View ca opțiuni, al doilea e lista din service.

| # | Cerință | DoD |
|---|---|---|
| Z0a | `Main` are **două linii**: creezi `PizzaView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| Z0 | Meniu cu opțiunile aplicației (vezi meniul pizzeriei / comandă / adaugă pizza / modifică preț) + `0. Iesire`. | Tastezi 1, vezi pizzele, meniul de opțiuni reapare. Tastezi 0 → programul se termină. |
| Z0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

---

## Nivel 1 — CRUD complet

| # | Cerință | DoD |
|---|---|---|
| Z1 | Adaugi o pizza în meniu, cu validare (nume nevid, preț > 0). | Pizza cu preț 0 → respinsă, meniul rămâne neschimbat. |
| Z2 | Modifici prețul unei pizze. | Prețul se schimbă în meniu. Nume inexistent → mesaj. |
| Z3 | Scoți o pizza din meniu. | A doua ștergere a aceleiași pizze eșuează, meniul nu se strică. |
| Z4 | Marchezi o pizza ca indisponibilă azi și, separat, o pui înapoi pe disponibil. | Marchezi „Diavola" indisponibilă → comanda ei dă „Momentan indisponibilă". O pui la loc → comanda merge. |

## Nivel 2 — comenzi

| # | Cerință | DoD |
|---|---|---|
| Z5 | Comanzi o pizza. Trei rezultate: nu e în meniu / e în meniu dar indisponibilă / se poate comanda. | Toate trei ramurile rulate, fiecare cu mesajul ei. Decizia stă **într-un singur loc**, în service — nu împrăștiată prin `Play()`. |
| Z6 | Nota de plată pentru mai multe pizze comandate deodată. | Primești o listă de nume, întorci totalul. O pizza inexistentă în comandă nu strică totalul celorlalte, dar apare în mesaj. |
| Z7 | Reducere „happy hour": 20% la toate pizzele disponibile. | Cele indisponibile ies cu prețul neatins. |

## Nivel 3 — rapoarte și cazuri limită

| # | Cerință | DoD |
|---|---|---|
| Z8 | Toate pizzele disponibile azi. | Lista returnată e goală, nu `null`, dacă niciuna nu e disponibilă. |
| Z9 | Prețul mediu al meniului și cea mai ieftină pizza **disponibilă**. | Cea mai ieftină din meniu e indisponibilă → răspunsul e alta. Ăsta e tot testul. |
| Z10 | Două pizze cu același nume în meniu. | Decizi ce e corect: le interzici la adăugare, sau comanda o ia pe prima. Orice alegi, fă-o să se comporte la fel de fiecare dată — și verifică rulând exact cazul ăsta. |
| Z11 | Comanzi dintr-un meniu gol. | Fără crash, mesaj corect. |
| Z12 | Programul nu crapă dacă la „Pret:" tastez `abc`. | Mesaj că nu e număr, pizza **nu** e adăugată, meniul reapare. |
| Z13 | Comanda se dă alegând **numărul** pizzei din listă, nu tastând numele. | Afișezi meniul numerotat, omul tastează `2`. Un număr în afara listei → mesaj, fără crash. Numerotarea o face View-ul. |
