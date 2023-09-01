# LA_ILA2_1300_Einarbeitung Numberguesser

### Gruppe: Sacher Robin

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt entwickle ich ein Numberguesser mit der Programmiersprache C#, der Rückmeldung gibt, ob die geratene Zahl zu hoch, zu tief oder genau richtig ist. Ausserdem baue ich einen Singleplayer und einen Multiplayer ein, indem man z.B. mit einem Freund spielen kann.

### 1.2 Ihre Ziele
LZ 1: 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |      Muss           |  Funktional    | Als ein User möchte ich, dass der Computer eine Zufallszahl zwischen und mit 1 bis 100 als Geheimzahl speichert, damit ich sie erraten kann. |
| 2  |      Muss           |  Funktional    | Als ein User möchte ich, dass der Benutzer Zahlen raten kann, damit man das Spiel gewinnen kann.                        |
| 3.1|      Muss           |  Funktional    | Als ein User möchte ich, dass der Computer einen Hinweis für jedene Geratene Zahl ausgibt, damit ich weis, ob ich gewonnen habe oder nicht    |
| 3.2|      Muss           |  Funktional    | Als ein User möchte ich, dass der Computer mir sagt: "Die geratene Zahl ist niedriger als die Geheimzahl." , wenn meine Zahl zu klein war.    |
| 3.3|      Muss           |  Funktional    | Als ein User möchte ich, dass der Cumputer mir sagt: "Die geratene Zahl ist grösser als die Geheimzahl.", wenn meine Zahl zu gross war.   |
| 3.4|      Muss           |  Funktional    | Als ein User möchte ich, dass der Cumputer mir sagt: "Die Geheimzahl wurde erraten.", wenn ich die Zahl erraten habe.                         |
| 4  |      Muss           |  Funktional    | Als ein User möchte ich, dass wenn ich die Zahl erraten haben, der Computer die anzahl versuche ausgibt.                                   |
| 5  |      Muss           |  Funktional    | Als ein User möchte ich, dass Fehleingaben abgefangen werden.                                   |
| 6  |      Muss           |  Funktional    | Als ein User möchte ich, dass die Schriftfarbe der Korrekt geratenen Zahl Grün und der faschen geratenen Zahlen Rot ist         |
| 7  |      Muss           |  Funktional    | Als ein User möchte ich, dass ich in einem Multiplayer Spielmodus spielen kann.|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |              |         |                   |
| ...  |              |         |                   |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme
<img width="220" alt="image" src="https://github.com/robinsacher/LA_ILA2_1300_Einarbeitung/assets/110891559/06ab9516-dcae-4d61-bca1-521cba981790">

<img width="513" alt="image" src="https://github.com/robinsacher/LA_ILA2_1300_Einarbeitung/assets/110891559/01c339b2-9210-43f1-b9d1-fb34994bba51">

<img width="483" alt="image" src="https://github.com/robinsacher/LA_ILA2_1300_Einarbeitung/assets/110891559/b6db8190-8c0e-425d-a326-334733487050">

<img width="661" alt="image" src="https://github.com/robinsacher/LA_ILA2_1300_Einarbeitung/assets/110891559/ecb1a585-0638-43fb-99b4-e95d136535d3">



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  01.09.2023     |  Sacher         |  Geheimzahl generieren                                          | 15 Min              |
| 2.A  |  01.09.2023     |  Sacher         |  Eingabe von Zahlen                                             | 15 Min              |
| 3.A  |  01.09.2023     |  Sacher         |  Ausgabe von einem Hinweis                                      | 30 Min              |
| 3.B  |  01.09.2023     |  Sacher         |  Ausgabe von einem Hinweis, für zu kleine Zahlen                |  5 Min              |
| 3.C  |  01.09.2023     |  Sacher         |  Ausgabe von einem Hinweis, für zu grosse Zahlen                |  5 Min              |
| 3.D  |  01.09.2023     |  Sacher         |  Ausgabe von einem Hinweis, für richtige Zahlen                 |  5 Min              |
| 4.A  |  01.09.2023     |  Sacher         |  Ausgabe von Anzahl versuchen                                   | 30 Min              |
| 5.A  |  01.09.2023     |  Sacher         |  Fehleingaben abfangen                                          | 30 Min              |
| 6.A  |  01.09.2023     |  Sacher         |  Schriftfarbe für richtige Zahl Grün und für falsche Zahl rot   | 30 Min              |
| 7.A  |  01.09.2023     |  Sacher         |  Multiplayer umsetzen                                           | 30 Min              |


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
