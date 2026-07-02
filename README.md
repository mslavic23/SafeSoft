# SafeSoft
SafeSoft je softver za obradu licenci.

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Magdalena Slavić | mslavic23@foi.hr | 0016169199 | mslavic23

## Opis domene
SafeSoft je aplikacija namjenjena IT odjelima srednjih i velikih poduzeća koja se suočavaju s izazovom netransparentnog korištenja softverskih licenci. U sustavu gdje organizacija može imati puno različitih pretplata i doživotnih licenci, često dolazi do poteškoća ili problema zbog plaćanja neaktivnih licenci ili rizika zbog korištenja softvera izvan dogovorenih uvjeta.
Aplikacija SafeSoft služi kao centralni repozitorij (mjesto) i kontrolni mehanizam koji omogućuje evidenciju nabave, dodjelu ključeva zaposlenicima te automatsko praćenjep parametra poput datuma isteka i preostalih slobodnih kvota. Cilj sustava je osigurati maksimalnu iskorištenost resursa uz pravnu usklađenost.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis 
------ | ----- | ----------- 
F01 | Upravljanje unosom licenci | Korisnici moraju moći unijeti zahtjev koji sadrži ime, email, naziv softvera, identifikaciju uređaja (npr. inventarni broj) i razlog korištenja. 
F02 | Evidentiranje novih licenci | IT administratori moraju moći unijeti nove licence u sustav te označiti pripadaju li "Per-seat" modelu ili "Pretplati po korisniku".
F03 | Pregled instaliranih licenci | Sustav mora omogućiti administratorima uvid u to na kojim se računalima instaliravaju određene licence.
F04 | Praćenje statusa zahtjeva| Korisnici moraju imati mogućnost praćenja što se s njihovim podnesenim zahtjevom događa u stvarnom vremenu
F05 | Prikaz raspoloživosti licenci | Sustav mora prikazati broj zauzetih instalacija ili "sjedala" s obzirom na ukupni broj kupljenih licenci kako bi se izbjegao lažni broj zauzetosti.
F06 | Prikaz aktivnih preplati | Sustav će pratiti aktivne preplate preko popisa aktivnih pretplati te će biti prikazan slobodan broj licenci.
F07 | Izvještaj dostupnosti licenca | Izvještaji će kreirati prikaz broja instalacija licenci te će to služiti i kao dodatna vizualna potvrda za slobodne licence, tj. jesu li podaci dobro usklađeni.
F08 | Deaktiviranje licence | Omogućiti evidentiranje uklanjanja softvera kako bi se licenca automatski vratila u dio od onih dostupnih.
NF01 | Izgled softvera | Deskop aplikacija treba biti optimizirana za rad u Windows okruženju te treba biti vizualno i estetski intuitivna i funkcionalna za korisnika.
NF02 | Sigurnost rada u mrežnoj domeni | Aplikacija mora biti dizajnirana isključivo za rad unutar interne mreže Fakulteta kako bi se osigurala privatnost podataka o IT infrastrukturi.

## Tehnologije i oprema
IDE: Visual Studio 2022
Jezik i framework: C# i .NET 6/8 (WPF ili WinForms)
Baza podataka: Microsoft SQL Server ili SQLite (uz Entity Framework Core)
Verzioniranje: Git (GitHub) uz korištenje GitHub Projects za praćenje zadataka
Dokumentacija: Markdown (README.md) i GitHub Wiki
dokumentacija sustava kontinuirano nadograđivati u GitHub Wikiju. Svi korišteni alati i tehnologije su javno dostupni i posjeduju odgovarajuće licence za razvoj akademskih softverskih projekata.
