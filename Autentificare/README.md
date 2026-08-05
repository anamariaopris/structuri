# Autentificare — exerciții

Aplicația: înregistrare + login. Ai două modele în folder: `Utilizatori.cs` (`username`, `parola`,
cu metoda `Login` deja scrisă) și `User.cs` (`name`, `email`, `password`, `age`, `isActive`).

**Fără indicii.** `UtilizatoriService.cs` și `UtilizatoriView.cs` sunt **goale** — scrii tot, de la lista privată în sus.
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
| U0a | `Main` are **două linii**: creezi `UtilizatoriView` și chemi `Play()`. Bucla de meniu stă în `Play()`, în View. | `Program.cs` nu conține niciun `Console.` și niciun `while`. Rulezi și meniul apare. |
| U0 | Meniu cu opțiunile aplicației (înregistrare / autentificare / vezi utilizatorii / șterge cont) + `0. Iesire`. | Te înregistrezi, apoi te autentifici cu același cont, în aceeași rulare. Tastezi 0 → programul se termină. |
| U0b | O tastă care nu e în meniu nu strică nimic. | Tastezi `9` → mesajul din `default`, meniul reapare. Tastezi `x` → programul **crapă**: `Int32.Parse` nu știe ce e `x`. E normal deocamdată — îl repari la ultimul nivel. |

## Nivel 1 — conturi

| # | Cerință | DoD |
|---|---|---|
| U1 | Înregistrezi un utilizator nou. | Username-ul trebuie să fie **unic**. Al doilea „ana" e respins, cu mesaj care spune de ce. |
| U2 | Autentifici un utilizator (username + parolă). | Trei rezultate distincte: reușit / parolă greșită / username inexistent. Verificarea parolei o face metoda `Login` care **există deja** pe model — service-ul o cheamă, nu o rescrie. |
| U3 | Ștergi un cont. | A doua ștergere a aceluiași cont eșuează. |
| U4 | Compari cu vechiul `Exercitiul13` (`git show a6501ce:Program.cs`) — aceeași autentificare, scrisă tot în `Main`. | Metoda ta din View are 4–5 linii și niciun `for`. Scrie în două rânduri ce s-a mutat și unde. |

## Nivel 2 — validări

| # | Cerință | DoD |
|---|---|---|
| U5 | Parola trebuie să aibă cel puțin 6 caractere. | „abc" → respins la înregistrare, contul **nu** e creat. |
| U6 | Username-ul nu poate fi gol și nu poate conține spații. | „ana maria" → respins. „ana.maria" → acceptat. |
| U7 | Schimbi parola: ceri parola veche, apoi pe cea nouă. | Parola veche greșită → schimbarea eșuează și **parola rămâne cea veche** (verifică autentificându-te după). Parola nouă prea scurtă → respinsă. |
| U8 | Ascunzi parola când se tastează (apar `*` în loc de litere). | Provocare de View, nu de service. Caută singură cum se citește o tastă fără să apară pe ecran. |

## Nivel 3 — cont blocat

| # | Cerință | DoD |
|---|---|---|
| U9 | Adaugi pe model un contor de încercări greșite. | După 3 parole greșite consecutive, contul se blochează și nici parola corectă nu mai intră. |
| U10 | O autentificare reușită resetează contorul. | 2 greșeli, apoi una corectă, apoi 2 greșeli → contul **nu** e blocat. Rulează exact secvența asta. |
| U11 | Deblochezi un cont. | După deblocare, parola corectă intră din nou. |

## Nivel 4 — al doilea model

| # | Cerință | DoD |
|---|---|---|
| U12 | Folosești `User` (are `email`, `age`, `isActive`) și validezi emailul: trebuie să conțină `@`. | „ana.gmail.com" → respins. |
| U13 | Dezactivezi un cont (`isActive = false`) fără să-l ștergi. | Un cont dezactivat nu se poate autentifica, dar apare în listare, marcat „inactiv". |
| U14 | Rapoarte: câți utilizatori sunt activi, câți inactivi, care e vârsta medie. | Vârsta medie pe listă goală nu crapă și nu afișează `NaN`. |
