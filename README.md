# GroceryApp sprint3 Studentversie  

## GitFlow Workflow

Dit project maakt gebruik van een aangepaste GitFlow-structuur.  
Hieronder staat uitgelegd hoe we met branches werken en hoe je nieuwe code toevoegt.

### Branches
- **main**  
  Bevat de stabiele productiecode. Alleen releases en hotfixes komen hier terecht.

- **develop**  
  Hier wordt alle ontwikkelcode samengebracht vanuit feature-branches.  
  Beschouw dit als de "werkversie" die klaarstaat voor de volgende release.

- **release/**  
  Wordt pas aangemaakt als de develop branch stabiel genoeg is om een release te maken.  
  Bijvoorbeeld: `release/release-v1.0.0`.

- **feature/**  
  Elke nieuwe feature of use case krijgt zijn eigen branch.  
  Bijvoorbeeld:
    - `feature/UC05`
    - `feature/UC06`

- **hotfix/**  
  Wordt gebruikt om dringende fixes te doen op productiecode.  
  Bijvoorbeeld: `hotfix/hotfix-v1.0.1`.
  Deze word vanuit de main branch gemaakt en na afronding gemerged naar zowel main als develop.
    
## UC07 Delen boodschappenlijst  
Is compleet  
  
## UC08 Zoeken producten  
Aanvullen:
- In de GroceryListItemsView zitten twee Collection Views, namelijk één voor de inhoud van de boodschappenlijst en één voor producten die je toe kunt voegen aan de boodschappenlijst  
- Voeg boven de tweede CollectionView een zoekveld (SearchBar) in om op producten te kunnen zoeken.  
- Zorg dat de SearchCommand wordt gebonden aan een functie in het onderliggende ViewModel (GroceryListItemsViewModel) en dat de zoekterm die in het zoekveld is ingetypt gebruikt wordt als parameter (SearchCommandParameter).  
- Werk in het viewModel (GroceryListItemsViewModel) de zoekfunctie uit en zorg dat de beschikbare producten worden gefilterd op de zoekterm!  

## UCx Registratie gebruiker 
Of een ander idee zelf uitwerken. Dit betekent ook dat de documentatie hiervoor ontwikkeld moet worden.

  

