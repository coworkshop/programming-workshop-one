# programming-workshop-one

Et API for å beskrive tepraturen ute, med fem endepunkt:

1. Endepunkt 1: /api/weather/description/coldest
    - Gir den kaldeste beskrivelsen
2. Endepunkt 2: /api/weather/description/hottest
    - Gir den varmeste beskrivelsen

3. Endepunkt 3: /api/weather/description/{temperature}
    - Sende inn en tempratur og få en beskrivelse
4. Endepunkt 4: /api/weather/average/at/{date-time}
    - Sende inn en date time og få en beskrivelse
5. Endepunkt 5: /api/weather/average/now/
    - Få en beskrivelse basert på tildspunktet nå

# Del 1:
- Refactor et par kodesnutter uten å feile testen (functional)
    - Min, Max og Sum
    - Hensikt: Bli litt varm i trøya
- Refactor en test
    - Få med alle gode prinsipper (tdd-workshop)
    - Hensikt: Forstå konseptet med lesbare tester

# Del 2:
- Fyll ut innholdet i en test, og få den til å bli grønn
- Endepunkt 3, 4 og 5 (bonus)

# Del 3:
- Få den til å deploye?
- CI/CD