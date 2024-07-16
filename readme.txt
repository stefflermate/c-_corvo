Szoftver-technológia 2. Beadandó adatbázisterv

Adatbázisomban egy cégnek a rendelési adatai szerepelnek. A cég foglalkozását tekintve azt vállalja hogy hogy ha egy bútor nagykereskedésben (pl: Ikea, Kika) vesszek egy vagy több terméket akkor ők ki tudják nekem szállítani és a termékek összeszerelését is vállalják. Az adatbázis a cégnek segítene abban hogy jobban át tudják látni a rendeléseket és ezáltal hatékonyabban tudják végezni a kiszállításokat.
Tábláim:
Kategoria:
•	KategoriaSK: Ez a tábla elsődleges kulcsa, automatikusan számlálódó tiny int típsú. A Termék tábla KategoriaFK sorával áll kapcsolatba.
•	Kategoria_név: Kategoriák neve szerepel itt nvarchar(40) típusú.
Márka:
•	MárkaSK: Ez a tábla elsődleges kulcsa, automatikusan számlálódó tiny int típsú. A Termék tábla MárkaFK sorával áll kapcsolatba.
•	Márka_név: Márka nevek szerepelnek ebbe a sorba nvarchar(40) tipusban.
Termék:
•	TermékSK: Ez a tábla elsődleges kulcsa, automatikusan számlálódó tinyint típusú. A Rendelt_Termék tábla TermékFK sorával áll kapcsolatba.
•	KategoriaFK: Idegen kulcs tinyint típusú. A Kategoria tábla KategoriaSK sorával áll kapcsolatba.
•	MárkaFK: Idegen kulcs tinyint típusú. A Márka tábla MárkaSK sorával áll kapcsolatba.
•	Ár: A termék árát jelzi int típusú.
•	Elemszám: A termék összeszereléséhez szükséges darabok száma szereppel benne tinyint típusú.
•	Súly: A termék súlya írja le kgban int típusú.
•	Méret: A termék dobozának méretét adja meg köbméterben int típusú
Rendelt_Termék:
•	RendelésazonosítóSK: Ez a tábla elsődleges kulcsa, automatikusan számlálódó tinyint típusú.
•	RendelésFK: Idegen kulcs tinyint típusú. A Rendelés tábla RendelésSK sorával áll kapcsolatba.
•	TermékFK: Idegen kulcs tinyint típusú. A Termék tábla TermékSK sorával áll kapcsolatba.
•	Mennyiség: Azt írja le hogy adott termékből hányat rendeltek egy rendelésben int típusú.
Rendelés:
•	RendelésSK: Ez a tábla elsődleges kulcsa, automatikusan számlálódó tinyint típusú. A Rendelt_Termék tábla RendelésFK sorával áll kapcsolatba.
•	VásárlóFK: Idegen kulcs tinyint típusú. A Vásárló tábla VásárlóSK sorával áll kapcsolatba.
•	Rendelés_Dátum: A rendelés dátumát adja meg datetime2(7) típusú.
•	Összeszerelés: Azt írja le hogy kérnek e szerelést, bit típusú.
•	FizetésimódFK: Idegen kulcs tinyint típusú. A FizetésiMód tábla FizetésimódSK sorával áll kapcsolatba.
FizetésiMód:
•	FizetésimódSK: Ez a tábla elsődleges kulcsa, automatikusan számlálódó tinyint típusú. A Rendelés tábla FizetésimódFK sorával áll kapcsolatba.
•	Mód: Azt írja le hogy a vásárló milyen módon fizetne nvarchar(40) típusú.
Vásárló:
•	VásárlóSK: Ez a tábla elsődleges kulcsa, automatikusan számlálódó tinyint típusú. A Rendelés tábla VásárlóFK sorával áll kapcsolatba.
•	Név:  A vásárló neve szerepel itt nvarchar(40) típusú.
•	Cím: Kisszállítási cím szerepel itt nvarchar(60) típusú.
•	Email_cím: A vásárló emailcíme szerepel itt nvarchar(40) típusú.
Több-több kapcsolat:
	A Kategoria és a Termék tábla között M:N kapcsolat szereppel mert egy terméknek több fajta kategóriája is lehet és egy kategóriába több termék is tarozik.



