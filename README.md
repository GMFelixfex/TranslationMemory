# Softwaredesing SoSe2022: Translation Memory

## Dateistruktur

Alle Diagramme sind im Diagramms ordner zu finden.
Das Projekt is im TranslationMemoryForm oderner zu finden.
Der UnitTest ist im TranslationMemoryUnitTest ordner zu finden
Mann kann auch einfach die TranslationMemoryForm.sln öffnen, die projektmappe hat beide Teile integriert, sowie das Klassendiagram

## Projektinfos

Beide Projekte sind mit C# (net6.0) in Visual Studio Community geschrieben.
Das Hauptprojekt ist eine WinForms Applikation, demnach nicht aus mac oder linux rechnern nutzbar.
Der UnitTest ist mit NUnit gemacht (Standart Test system das bei Visual Studio mitgeliefert wird)

Das Projekt nutzt eine MongoDB Atlas datenbank ohne zwischengeschaltetem Server, 
demnach ist die Applikation Sicherheitstechnisch unbrauchbar, sowie abhängig vom Internet.

## Testbenutzer

Die Benutzernamen und passwörter sind wie Folgt:

 - Admin: 
	 - Username: TestAdmin 
	 - Password: 12345
 - Translator:
	 - Username: TestTranslator
	 - Password: 12345
 - User: 
	 - Username: TestUser 
	 - Password: 12345


##  Allgemeine Nutzungsinfos

Funktionen können dem UseCase diagramm entnommen werden.
Wichtig: Man kann sich registrieren und einloggen (jeweiliger button)
Im Hauptmenu muss man auf einen der Buttons kilcken um an die jeweilige funktion zu gelangen.

## Cleancode infos

Userdata ist absichtlich nicht UserData geschieben (für mich ist dies ein zusammenhängendes wort)
alle variablen klein mit neuen Wörtern groß
Klassen / Funktionen Groß
