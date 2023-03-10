# To_Do

## Opis Uruchomienia:

1. Aby uruchomić aplikację należy zainstalować pliki NuGet:
   * Microsoft.AspNetCore.Identity.EntityFrameworkCore wersja(6.0.13)
   * Microsoft.AspNetCore.Identity.UI wersja(6.0.13)
   * Microsoft.EntityFrameworkCore.Proxies wersja(6.0.13)
   * Microsoft.EntityFrameworkCore.SqlServer wersja(6.0.13)
   * Microsoft.EntityFrameworkCore.Tools wersja(6.0.13)
   * Microsoft.VisualStudio.Web.CodeGeneration.Design wersja(6.0.11)

#### Instrukcja instalacji pakietów NuGet

Ścieżka:
 * Narzędzia -> Menadżer pakietów NuGet -> Zarządzaj pakietami NuGet rozwiązania... -> Przeglądaj -> Wyszukaj -> Wybierz miejsce instalacji -> Wybierz wersję
 
 Narzędzia -> Menadżer pakietów NuGet -> Zarządzaj pakietami NuGet rozwiązania... :
 
 ![image](https://user-images.githubusercontent.com/93732758/215271982-36ce802a-5c16-4bc2-8662-a50f541d3260.png)
 
 Przeglądaj -> Wyszukaj :
 
 ![image](https://user-images.githubusercontent.com/93732758/215272112-db961c91-7422-41dd-9f34-a845e4dc91b6.png)
 
 Wybierz miejsce instalacji :
 
 ![image](https://user-images.githubusercontent.com/93732758/215272070-3ccc2a7c-1eaa-42bd-9fb2-e6ead836b107.png)
 
 Wybierz wersję :
 
 ![image](https://user-images.githubusercontent.com/93732758/215272137-b305cef8-7731-4fe4-af58-41e9de4de505.png)

2. Zmieniamy nazwa serwera bazadanowego na taki jaki posiadamy:
* Nazwa serwera dla SSMS

![image](https://user-images.githubusercontent.com/93732758/215159763-8bc09d02-3454-47fd-bcc0-4bc4674046ce.png)

3. W appsettings.json zmieniamy nazwę serwera:

![image](https://user-images.githubusercontent.com/93732758/215159577-80898fd4-9f60-46da-9195-515f0383aca9.png)
4. Aby aplikację działała poprawnia trzęba odpalić Konsole Menadzera Pakietów: 

![image](https://user-images.githubusercontent.com/93732758/215158848-bed1aa53-d578-42b5-b018-5a38527a1e68.png) 

5. Następnie wpisujemy w konsolii: update-database i klikamy enter.
6. Odpalamy projekt klikająć F5 albo bezpośrednio klikająć w kompilator

![image](https://user-images.githubusercontent.com/93732758/215160564-36f25291-2def-4f69-8590-7d12e515bced.png)

## Przykładowi użytkownicy:
* Niezarejestrowany użytkownik:
  * E-mail: test2@gmail.com
  * Hasło: Test2@

* Zarejestrowany użytkownik:
  * E-mail: test1@gmail.com
  * Hasło: Test1@

## Opis funkcji dla:

1. Niezarejestrowanych użytkowników:
* Nie mają dostępu do: [Twoja lista zadań] oraz [Kategorie].
* Jęśli niezarejsestrowani użytkownicy będą próbowali wejść w daną opcję zostaną przekierowani do strony z logowaniem.
2. Zarejestrowanych użytkowników:
* Posiada dostęp do: [Twoja lista zadań] oraz [Kategorie].

 [Kategorie]
* Po kliknięciu wyświetla sie formularz 

![image](https://user-images.githubusercontent.com/93732758/215161927-75b79712-23e8-4380-9a8a-f58c3e6f15dd.png)

* Po utworzeniu kategorii zostaje ona wyświetlona.

![image](https://user-images.githubusercontent.com/93732758/215163426-77b29b15-9a47-499b-b900-4ce5388fbfa0.png)
* Można ją edytować i usunąć

[Twoje listy zadań]
* Po kliknięciu wyświetla sie formularz

![image](https://user-images.githubusercontent.com/93732758/215193952-ef32c6e4-f98f-4014-a6b4-b63b7e9124b7.png)
* Po utworzeniu listy zostaje ona wyświetlona 
* Można ją edytować, wyświelić oraz usunąć

![image](https://user-images.githubusercontent.com/93732758/215194579-760944d7-d10b-442a-bc3a-45956c11cb0f.png)

* Po przyciśnięciu przycisku Wyświetl zostajemy przekierowani do formularza, gdzie możemy dodawać zadania dla danej listy.

![image](https://user-images.githubusercontent.com/93732758/215195388-34d5a185-e3f5-4735-a062-41eacbf941f8.png)
* Po dodaniu zadań możemy je edytować, usunąć, a także zacznaczyć czy jest zrobione zadanie

![image](https://user-images.githubusercontent.com/93732758/215195583-d60fd6b8-6701-4161-9ab7-f7de7385e321.png)

### Walidacje
1. Formularz logowania

![image](https://user-images.githubusercontent.com/93732758/215202498-1fc0635f-1a1e-48be-b403-0071f3ec6d7a.png)

2. Formularz rejestracji

![image](https://user-images.githubusercontent.com/93732758/215202661-7e5379bc-8e16-4bdd-ab49-74c48a9bf26d.png)

3. Formularz listy zadań

![image](https://user-images.githubusercontent.com/93732758/215204947-ac94b992-8774-4773-a76e-383f7a420c5d.png)

4. Formularz zadań
 
![image](https://user-images.githubusercontent.com/93732758/215205009-6e2fb952-47f3-4a8d-a969-e11c11440c58.png)

5. Formularz kategorii

![image](https://user-images.githubusercontent.com/93732758/215205161-841b3615-4f73-4e01-93c1-3df8bd2e3aff.png)

