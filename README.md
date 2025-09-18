# programming-workshop-one

Dette repoet er laget for å forstå noen grunnleggende konsepter innen programmering, testing og deployering.

## Innhold
### Math
- En klasse med noen mattefunksjoner (Math.cs) i tillegg til tester for disse (MathTests.cs)

### Weather API
- Et enkelt web API som gir værbeskrivelser basert på temperatur og tid. 

Endepunkt 1 og 2 er allerede implementert med tester, men testene er ganske rotete. Endepunkt 3, 4 og 5 er ikke implementert, og har ingen tester, men skallet for controller og testklasse er der, i tillegg til "databaseintegrasjonen". 


1. Endepunkt 1: /api/weather/description/coldest
    - Gir den kaldeste beskrivelsen
2. Endepunkt 2: /api/weather/description/hottest
    - Gir den varmeste beskrivelsen

3. Endepunkt 3: /api/weather/description/{temperature}
    - Sende inn en temperatur og få en beskrivelse
4. Endepunkt 4: /api/weather/average/at/{date-time}
    - Sende inn en date time og få en beskrivelse
5. Endepunkt 5: /api/weather/average/now/
    - Få en beskrivelse basert på tidspunktet nå

### Infrastruktur og pipelines
- En Bicep template som setter opp de nødvendige ressursene i Azure.
- En Azure pipeline for å deploye infrastrukturen.
- En Azure pipeline for å bygge, teste og deploye API'et.

### Dokumentasjon
- Denne filen (README.md) som gir en oversikt over oppsett, oppgaver og kjente use caser.
- Architectural guidelines i docs/architectural-guidelines.md som forklarer avgjørelser tatt (og ikke tatt :)) i prosjektet.
- Tester som beskriver hva appen kan gjøre og det forventede resultatet. 
- Swagger-dokumentasjon som beskriver API'et.

# Oppgaver:
## Del 1:
- Refactor et par kodesnutter uten å feile testen (functional)
    - Min, Max og Sum
    - Hensikt: Bli litt varm i trøya
- Refactor en test i WeatherDescriptionTests.cs
    - Få med alle gode prinsipper (tdd-workshop)
    - Hensikt: Forstå konseptet med lesbare tester

## Del 2:
- Implementer endepunkt 3, 4 og 5 i WeatherDescriptionController.cs og WeatherAveragesController.cs med tester. Er det mulig å skrive testen først?

## Del 3:
- Sett opp en pipeline som deployer Azure Resourcen som API'et skal kjøre på
- Sett opp en pipeline som deployer API'et til Azure


# Oppsett
- Du trenger .NET 8 SDK installert
- Et IDE, som helst kan håndtere C# og .NET. og som kan kjøre og teste prosjektet. F.eks. Visual Studio eller JetBrains Rider. Kan gjøres med .NET CLI i VS Code også, eventuelt plugins i VS Code.