Denne applikation tillader dig at søger i en stor mængde bøger, med forfatter navn, titel og byer. Her kan du forholdvis få vist byer nævnt i teksterne på et kort, få en liste over hvilke byer nævnes i hvilke bøger og mere.



Hvilke databaser er brugt?
For at udfordre mig selv har jeg valgt at bruge MongoDB og SQL (ikke færdiggjort). 
Hvordan er data modelleret i din database?
MongoDB database har ikke rigtig nogle model, hvilket betyder at det ser sådan ud i databasen.


![Database](https://i.imgur.com/NEfDltX.png)

Hvordan er data modelleret i din applikation?


![Database]( https://i.imgur.com/hPcTlIH.png)


![Database]( https://i.imgur.com/JCj14kr.png)

Hvad angår SQL databasen er den ikke i brug, men databasen er lavet og tabellerne er ligeledes lavet. Dataen er opbevaret i en mange til mange relation som ser således ud:


 	Id	int	False	 
  	city	nvarchar(50)	True	 
  	city_ascii	nvarchar(50)	True	 
 	lat	nvarchar(50)	True	 
     	ing	nvarchar(50)	True	 
 	country	nvarchar(50)	True	 
 	 	 	 	 

 	Id	int	False	 
 	Bookid	int	True	 
 	Cityid	int	True	 
 	 	 	 	 

 	id	int	False	 
 	Title	nvarchar(50)	True	 
 	Author	nvarchar(50)	True	 
 	 	 	 	 

Hvordan er data importeret?

Dataen blev først installeret igennem terminalen, hvorpå der blev skabt en drouplet, og derefter blev der forbundet til den med en SSH key hvorefter man overførte dataen til drouplet igennem de fulgte instrukser der var i opgave beskrivelsen. Herefter installerede man den ned med FileZilla på computeren. 
Hvad angår at få dataen over på databasen igennem det byggede program var det således:
Hver teksten køres igennem Standford project, hvorefter der tilføjes ”/LOCATION” udfra en hver by/land. Derefter tages disse ud og ligges i City-listen i Book-objektet, hvor efter det bliver smidt direkte ind på databasen igennem følgende linje:
  collection.InsertOne(new Book(vs[0], vs[1], cities.ToList()));

Resultat af query test set. 

Testen gav det forventede udkom, bortset fra at den sidste query ikke er fungerende. Derudover er der nogle fejl som er værd at nævne ude de resteren queries. Blandt dem er at byer bestående er to ord, eksempelvis "New York" kan ikke vises da Standford Project viser dem som seperate byer. (NEW/LOCATION YORK/LOCATION).
En anden fejlkilde der kan være i resultaterne er at den by som var til hensigt at nævne i bøgerne, deler navn med mange andre byer. Eksempelvis findes London i Syd Afrika, USA, og UK. Her har jeg bare valgt at vælge det første match da det ellers ville forøge data drastisk. 

Hvad angår runtime hastighed er den største synder nok logikken, specielt i file-reader delen da det tager ret lang tid at gennemgå teksterne. Hvad angår backenden så er den ikke lige så syndig.

MongoDB passer fint med denne type projekt, pga. fleksibilitet af mongoDB. 
