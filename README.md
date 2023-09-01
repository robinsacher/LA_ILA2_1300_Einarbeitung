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
[Uploading <?xml version="1.0" encoding="utf-8"?>
<FRAME GUID="2FB25471-B62C-4EE6-BD43-F819C095ACF8" FORMAT="0000" APP_VERSION="2.2.0.8" CHECKSUM="A964EFC6D532DBE8">
  <PROJECT FORMAT="1.00" NAME="Numberguesser" AUTHOR="sacherrobin" CREATED="2023.09.01 09:39:04" MODIFIED="2023.09.01 09:59:32">
    <DIAGRAMS>
      <DIAGRAM FORMAT="1.00" ID="0" NAME="Hauptprogramm 1" CREATED="2023.09.01 09:39:10" MODIFIED="2023.09.01 09:59:32">
        <LAYOUT FORMAT="1.00" COLUMNS="8" ROWS="26">
          <ENTRIES>
            <ENTRY COLUMN="0" ROW="7">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="110">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="0" ROW="23">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="80">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="1" ROW="9">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="41">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="1" ROW="11">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="34">
                <TEXT><![CDATA[Ausgabe von "Number was too small"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="1" ROW="12">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="35">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="1" ROW="17">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="59">
                <TEXT><![CDATA[Ausgabe von "Number was too small]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="1" ROW="18">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="61">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="2" ROW="9">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="38">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="2" ROW="11">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="33">
                <TEXT><![CDATA[Ausgabe von "Number was too big"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="2" ROW="12">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="30">
                <TEXT><![CDATA[Zahl zu Gross?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="2" ROW="17">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="58">
                <TEXT><![CDATA[Ausgabe von "Number was too big"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="2" ROW="18">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="56">
                <TEXT><![CDATA[Zahl zu Gross?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="0" ANCHOR="True">
              <FIGURE SUBTYPE="PapTitle" FORMAT="1.00" ID="0">
                <TEXT><![CDATA[Hauptprogramm 1]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="1">
              <FIGURE SUBTYPE="PapStart" FORMAT="1.00" ID="1">
                <TEXT><![CDATA[Start]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="2">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="4">
                <TEXT><![CDATA[Ausgabe von "Welcome in the Numberguesser. Try to guess the random Number between 1 and 100"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="3">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="6">
                <TEXT><![CDATA[Ausgabe von "Singleplayer or Multiplayer?"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="4">
              <FIGURE SUBTYPE="PapInput" FORMAT="1.00" ID="8">
                <TEXT><![CDATA[Eingabe von Spielmodus]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="5">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="10">
                <TEXT><![CDATA[Singleplayer oder Multiplayer?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="7">
              <FIGURE SUBTYPE="PapActivity" FORMAT="1.00" ID="14">
                <TEXT><![CDATA[Generierern von Zufallszahl 1]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="8">
              <FIGURE SUBTYPE="PapActivity" FORMAT="1.00" ID="16">
                <TEXT><![CDATA[Generieren von Zufallszahl 2]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="9">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="18">
                <TEXT><![CDATA[Ausgabe von "Player 1 enter a number"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="10">
              <FIGURE SUBTYPE="PapActivity" FORMAT="1.00" ID="44">
                <TEXT><![CDATA[counter ++]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="11">
              <FIGURE SUBTYPE="PapInput" FORMAT="1.00" ID="20">
                <TEXT><![CDATA[Eingabe von Zahl]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="12">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="22">
                <TEXT><![CDATA[Zahl = Zufallszahl 1?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="14">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="46">
                <TEXT><![CDATA[Ausgabe von "Player 1 guessed the Number"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="15">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="48">
                <TEXT><![CDATA[Ausgabe von "Player 2 enter a number"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="16">
              <FIGURE SUBTYPE="PapActivity" FORMAT="1.00" ID="50">
                <TEXT><![CDATA[counter2 ++]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="17">
              <FIGURE SUBTYPE="PapInput" FORMAT="1.00" ID="52">
                <TEXT><![CDATA[Eingabe von Zahl]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="18">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="54">
                <TEXT><![CDATA[Zahl = Zufallszahl 2?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="19">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="64">
                <TEXT><![CDATA[Ausgabe von "Player 2 guessed the Number"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="20">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="66">
                <TEXT><![CDATA[counter 1 > counter 2?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="21">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="70">
                <TEXT><![CDATA[Ausgabe von "Player 1 Won"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="22">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="72">
                <TEXT><![CDATA[Ausgabe von "Play again"?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="23">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="74">
                <TEXT><![CDATA[Eingbabe == "yes"?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="24">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="168">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="3" ROW="25">
              <FIGURE SUBTYPE="PapEnd" FORMAT="1.00" ID="2">
                <TEXT><![CDATA[Ende]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="4" ROW="5">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="160">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="4" ROW="13">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="159">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="4" ROW="20">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="68">
                <TEXT><![CDATA[Ausgabe von "Player 2 won"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="4" ROW="22">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="115">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="5">
              <FIGURE SUBTYPE="PapActivity" FORMAT="1.00" ID="12">
                <TEXT><![CDATA[generieren von Zufallszahl]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="6">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="118">
                <TEXT><![CDATA[Ausgabe von "Enter a Number"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="7">
              <FIGURE SUBTYPE="PapActivity" FORMAT="1.00" ID="120">
                <TEXT><![CDATA[counter ++]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="8">
              <FIGURE SUBTYPE="PapInput" FORMAT="1.00" ID="122">
                <TEXT><![CDATA[Eingabe von Zahl]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="9">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="123">
                <TEXT><![CDATA[Zahl = Zufallszahl?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="10">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="148">
                <TEXT><![CDATA[Ausgabe von "You Won"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="11">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="150">
                <TEXT><![CDATA[Ausgabe von "You needed" + counter]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="12">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="151">
                <TEXT><![CDATA[Ausgabe von "Play again"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="13">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="154">
                <TEXT><![CDATA[Eingabe == "yes"?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="5" ROW="24">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="166">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="6" ROW="6">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="140">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="6" ROW="8">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="132">
                <TEXT><![CDATA[Ausgabe von "Number was too big"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="6" ROW="9">
              <FIGURE SUBTYPE="PapCondition" FORMAT="1.00" ID="128">
                <TEXT><![CDATA[Zahl zu gross?]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="7" ROW="6">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="145">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="7" ROW="8">
              <FIGURE SUBTYPE="PapOutput" FORMAT="1.00" ID="134">
                <TEXT><![CDATA[Ausgabe von "Number was too small"]]></TEXT>
              </FIGURE>
            </ENTRY>
            <ENTRY COLUMN="7" ROW="9">
              <FIGURE SUBTYPE="PapConnector" FORMAT="1.00" ID="135">
                <TEXT><![CDATA[]]></TEXT>
              </FIGURE>
            </ENTRY>
          </ENTRIES>
        </LAYOUT>
        <CONNECTIONS>
          <CONNECTION FORMAT="1.00" ID="3" FROM="1" TO="4" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="5" FROM="4" TO="6" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="7" FROM="6" TO="8" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="9" FROM="8" TO="10" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="11" FROM="10" TO="14" TEXT="Multiplayer" />
          <CONNECTION FORMAT="1.00" ID="161" FROM="160" TO="12" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="15" FROM="14" TO="16" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="17" FROM="16" TO="18" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="19" FROM="18" TO="44" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="21" FROM="20" TO="22" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="23" FROM="22" TO="46" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="27" FROM="30" TO="33" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="37" FROM="35" TO="34" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="25" FROM="22" TO="30" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="32" FROM="30" TO="35" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="39" FROM="33" TO="38" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="40" FROM="38" TO="18" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="42" FROM="34" TO="41" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="43" FROM="41" TO="38" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="45" FROM="44" TO="20" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="47" FROM="46" TO="48" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="49" FROM="48" TO="50" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="51" FROM="50" TO="52" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="53" FROM="52" TO="54" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="55" FROM="54" TO="64" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="57" FROM="54" TO="56" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="60" FROM="56" TO="58" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="62" FROM="56" TO="61" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="63" FROM="61" TO="59" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="65" FROM="64" TO="66" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="67" FROM="66" TO="70" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="69" FROM="66" TO="68" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="71" FROM="70" TO="72" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="73" FROM="72" TO="74" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="169" FROM="168" TO="2" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="77" FROM="74" TO="80" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="83" FROM="80" TO="110" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="112" FROM="110" TO="14" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="117" FROM="115" TO="72" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="114" FROM="68" TO="115" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="119" FROM="12" TO="118" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="121" FROM="118" TO="120" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="124" FROM="120" TO="122" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="125" FROM="122" TO="123" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="133" FROM="128" TO="132" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="127" FROM="123" TO="128" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="136" FROM="128" TO="135" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="137" FROM="135" TO="134" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="142" FROM="140" TO="118" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="139" FROM="132" TO="140" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="147" FROM="145" TO="140" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="144" FROM="134" TO="145" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="149" FROM="123" TO="148" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="152" FROM="150" TO="151" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="153" FROM="148" TO="150" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="155" FROM="151" TO="154" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="13" FROM="10" TO="160" TEXT="Singleplayer" />
          <CONNECTION FORMAT="1.00" ID="162" FROM="159" TO="160" TEXT="" />
          <CONNECTION FORMAT="1.00" ID="163" FROM="154" TO="159" TEXT="ja" />
          <CONNECTION FORMAT="1.00" ID="75" FROM="74" TO="168" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="165" FROM="154" TO="166" TEXT="nein" />
          <CONNECTION FORMAT="1.00" ID="170" FROM="166" TO="168" TEXT="" />
        </CONNECTIONS>
      </DIAGRAM>
    </DIAGRAMS>
  </PROJECT>
</FRAME>Numberguesser.pap…]()


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
