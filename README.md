# Uczelniana Wypożyczalnia Sprzętu

## Uruchomienie
1. Sklonuj repozytorium
2. Otwórz projekt w Rider lub Visual Studio
3. Upewnij się że masz zainstalowany .NET 10

## Struktura projektu
- **Klasy domenowe** - Equipment, Person oraz ich konkretne implementacje
- **Rental** - reprezentuje pojedyncze wypożyczenie wraz z terminem i ewentualną karą
- **RentalService** - odpowiada za wykonywanie operacji i egzekwowanie reguł biznesowych

## Decyzje projektowe
- Equipment i Person jako klasy abstrakcyjne - w systemie zawsze operujemy na konkretnym sprzęcie i użytkowniku, nigdy na samym "sprzęcie" czy "osobie"
- IRentable jako interfejs - wypożyczalność to kontrakt zachowania, nie cecha dziedziczona
- MaxRentals zdefiniowane w każdej podklasie użytkownika - zmiana limitu wymaga edycji tylko jednego miejsca
- Logika naliczania kary zamknięta w RentalService - nie jest rozproszona po innych klasach
- Model domenowy nie zawiera logiki biznesowej - klasy danych i klasy operacji są rozdzielone

## Kohezja i coupling
- Każda klasa ma jedną odpowiedzialność: Equipment przechowuje dane, RentalService wykonuje operacje
- Klasy są od siebie niezależne - zmiana w jednej nie wymusza zmian w innych
