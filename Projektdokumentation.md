# LA_ILA2_1300_Einarbeitung Numberguesser

### Gruppe: Sacher Robin

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt entwickle ich ein Numberguesser mit der Programmiersprache C#, der Rückmeldung gibt, ob die geratene Zahl zu hoch, zu tief oder genau richtig ist. Ausserdem baue ich einen Singleplayer und einen Multiplayer ein, indem man z.B. mit einem Freund spielen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |      Muss           |  Funktional    | Als ein User möchte ich, dass der Computer eine Zufallszahl zwischen und mit 1 bis 100 als Geheimzahl speichert, damit ich sie erraten kann. |
| 2  |      Muss           |  Funktional    | Als ein User möchte ich, dass der Benutzer Zahlenneingeben kann, damit man das Spiel gewinnen kann. |
| 3.a|      Muss           |  Funktional    | Als ein User möchte ich, dass der Computer einen Hinweis für jedene Geratene Zahl ausgibt, damit ich weis, ob ich gewonnen habe oder nicht    |
| 3.b|      Muss           |  Funktional    | Als ein User möchte ich, dass der Computer mir sagt: "Die geratene Zahl ist niedriger als die Geheimzahl." , wenn meine Zahl zu klein war.    |
| 3.c|      Muss           |  Funktional    | Als ein User möchte ich, dass der Cumputer mir sagt: "Die geratene Zahl ist grösser als die Geheimzahl.", wenn meine Zahl zu gross war.   |
| 3.d|      Muss           |  Funktional    | Als ein User möchte ich, dass der Cumputer mir sagt: "Die Geheimzahl wurde erraten.", wenn ich die Zahl erraten habe.                         |
| 4  |      Muss           |  Funktional    | Als ein User möchte ich, dass wenn ich die Zahl erraten haben, der Computer die anzahl versuche ausgibt.                                   |
| 5  |      Muss           |  Funktional    | Als ein User möchte ich, dass Fehleingaben abgefangen werden.                                   |
| 6  |      Muss           |  Funktional    | Als ein User möchte ich, dass die Schriftfarbe des Text der angezeigt wird zu grün geändert wird, wenn ich die richtige Zahl eingebe und dass er rot wird, wenn iche eine falsche Zahl eingebe.|
| 7  |      Muss           |  Funktional    | Als ein User möchte ich, dass ich in einem Multiplayer Spielmodus spielen kann.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |      Programm gestartet        |    Spielmodus gewählt     |     Spielmodus gestartet und Zufallszahl generiert             |
| 2.1  |      Programm gestartet        |    Zahl     |      Keine Ausgabe             |
| 3.a.1|      Programm gestartet        |    Zahl     |      Hinweis             |
| 3.b.1|      Programm gestartet        |    Zahl     |      Zahl zu klein             |
| 3.c.1|      Programm gestartet        |    Zahl     |      Zahl zu gross             |
| 3.d.1|      Programm gestartet        |    Zahl     |      Zahl richtig             |
| 4.1  |      Programm gestartet        |    richtige Zahl     |      Anzahl versuche             |
| 5.1  |      Programm gestartet        |    falsche Eingabe     |   Falscheingabe, bitte versuchen sie es erneut                |
| 6.1  |      Programm gestartet        |    Zahl     |   grüne oder rote Schriftfarbe                |
| 7.1  |      Programm gestartet        |    Multiplayer     |      Multiplayer wird gestartet             |

### 1.4 Diagramme

### Hauptporgramm
<img width="389" alt="image" src="https://github.com/robinsacher/LA_ILA2_1300_Einarbeitung/assets/110891559/262f9f21-494c-4be0-b554-bd4eefa34fae">

### Singleplayer
<img width="453" alt="image" src="https://github.com/robinsacher/LA_ILA2_1300_Einarbeitung/assets/110891559/9c58c253-9e4a-4360-ad2a-f4c2ffb3538b">

### Multiplayer
<img width="366" alt="image" src="https://github.com/robinsacher/LA_ILA2_1300_Einarbeitung/assets/110891559/520f83e1-decc-4a49-8bd2-e0437254d166">

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

Total: 3 Stunden 15 Minuten 

## 3 Entscheiden
Ich habe mich dazu entschieden, dass ich das Projekt so umsetzen kann und das keine Änderungen nötig sind.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  25.08.2023     |  Sacher         |  15 Min                                            | 15 Min              |
| 2.A  |  25.08.2023     |  Sacher         |  15 Min                                            | 15 Min              |
| 3.A  |  25.08.2023     |  Sacher         |  30 Min                                            | 30 Min              |
| 3.B  |  25.08.2023     |  Sacher         |   5 Min                                            |  5 Min              |
| 3.C  |  25.08.2023     |  Sacher         |   5 Min                                            |  5 Min              |
| 3.D  |  25.08.2023     |  Sacher         |   5 Min                                            |  5 Min              |
| 4.A  |  25.08.2023     |  Sacher         |  30 Min                                            | 30 Min              |
| 5.A  |  25.08.2023     |  Sacher         |  30 Min                                            | 60 Min              |
| 6.A  |  25.08.2023     |  Sacher         |  30 Min                                            | 30 Min              |
| 7.A  |  25.08.2023     |  Sacher         |  30 Min                                            | 90 Min              |

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  08.09.2023       |   OK       |   Robin Sacher      |
| 2.1  |  08.09.2023       |   OK       |   Robin Sacher      |
| 3.a.1|  08.09.2023       |   OK       |   Robin Sacher      |
| 2.b.1|  08.09.2023       |   OK       |   Robin Sacher      |
| 2.c.1|  08.09.2023       |   OK       |   Robin Sacher      |
| 2.d.1|  08.09.2023       |   OK       |   Robin Sacher      |
| 4.1  |  08.09.2023       |   OK       |   Robin Sacher      |
| 5.1  |  08.09.2023       |   OK       |   Robin Sacher      |
| 6.1  |  08.09.2023       |   OK       |   Robin Sacher      |
| 7.1  |  08.09.2023       |   OK       |   Robin Sacher      |

Alle Testfälle wurden erfolgreich fruchgeführt

## 6 Auswerten
Das Projekt ist sehr gut verlaufen, da wir im ersten Lehrjahr im Lernatelier schoneinmal ein numberguesser programmiert haben. Das einzig neue was hinzu gekommen ist, ist das OOP. Hier hatte ich am Anfang ein bisschen Mühe zu verstehen, wie man dies an einem konkreten Beispiel in der Praxis anwendet. Nun habe ich dies aber vertsanden.

## 7 Portfolioeintrag
[https://portfolio.bbbaden.ch/view/view.php?t=9b18d9b7665017829ba1)https://portfolio.bbbaden.ch/view/view.php?t=9b18d9b7665017829ba1](https://portfolio.bbbaden.ch/view/view.php?t=9b18d9b7665017829ba1)
