use BD5B6TP1_BrodeurLussier;
Print  'Création de la base de données de l''hôtel Plage Santé Inc.'
print  'Dernière modification, 19 septembre 2018.'
print ''
Print  'destruction des tables...'
DROP TABLE planifSoin;
DROP TABLE assistantSoin;
DROP TABLE assistant;
DROP TABLE soin;
DROP TABLE typeSoin;
DROP TABLE invite;
DROP TABLE reservationChambre;
DROP TABLE client;
DROP TABLE chambre;
DROP TABLE typeChambre;
DROP TABLE utilisateur;
DROP TABLE typeUtilisateur;


print 'Création des tables ========================================================'
print ''
Print  'Création de la TABLE typeSoin...' 
CREATE TABLE typeSoin (
	noTypeSoin			NUMERIC,
	description			VARCHAR(200),
	CONSTRAINT pk_typeSoin PRIMARY KEY (noTypeSoin)
	);

print 'Création de la TABLE soin...'
CREATE TABLE soin (
	noSoin				NUMERIC,
	description			VARCHAR(200),
	duree				NUMERIC,
	noTypeSoin			NUMERIC,
	prix				NUMERIC(9,2),
	CONSTRAINT pk_soin PRIMARY KEY (noSoin),
	CONSTRAINT fk_typeSoin FOREIGN KEY (noTypeSoin) REFERENCES typeSoin(noTypeSoin)
	);

print 'Création de la TABLE assistant...'
CREATE TABLE assistant (
	noAssistant			NUMERIC,
	prenom				VARCHAR(50),
	nom					VARCHAR(50),
	specialites			VARCHAR(500),
	remarques			VARCHAR(500),
	CONSTRAINT pk_assistant PRIMARY KEY (noAssistant)
	);

print 'Création de la TABLE assistantSoin...'
CREATE TABLE assistantSoin (
	noAssistant			NUMERIC,
	noSoin				NUMERIC,
	CONSTRAINT pk_assistantSoin PRIMARY KEY (noAssistant, noSoin),
	CONSTRAINT fk_assistant_assistantSoin FOREIGN KEY (noAssistant) REFERENCES assistant(noAssistant),
	CONSTRAINT fk_soin_assistantSoin FOREIGN KEY (noSoin) REFERENCES soin(noSoin)
	);

print 'Création de la TABLE planifSoin...'
CREATE TABLE planifSoin (
	noPersonne			NUMERIC,
	noAssistant			NUMERIC,
	dateHeure			DATETIME,
	noSoin				NUMERIC,
	CONSTRAINT pk_planifSoin PRIMARY KEY (noPersonne, noAssistant, dateHeure),
	CONSTRAINT fk_assistant_planifSoin FOREIGN KEY (noAssistant) REFERENCES assistant(noAssistant),
	CONSTRAINT fk_soin_planifSoin FOREIGN KEY (noSoin) REFERENCES soin(noSoin)
	);

print 'Création de la TABLE typeChambre...'
CREATE TABLE typeChambre (
	noTypeChambre		NUMERIC,
	description			VARCHAR(200),
	prixHaut			NUMERIC(9,2),
	prixBas				NUMERIC(9,2),
	prixMoyen			NUMERIC(9,2),
	CONSTRAINT pk_typeChambre PRIMARY KEY (noTypeChambre)
	);

print 'Création de la TABLE chambre...'
CREATE TABLE chambre (
	noChambre			NUMERIC,
	emplacement			VARCHAR(200),
	decorations			VARCHAR(500),
	noTypeChambre		NUMERIC,
	CONSTRAINT pk_chambre PRIMARY KEY (noChambre),
	CONSTRAINT fk_typeChambre FOREIGN KEY (noTypeChambre) REFERENCES typeChambre(noTypeChambre)
	);

print 'Création de la TABLE client...'
CREATE TABLE client (
	noClient			NUMERIC CONSTRAINT ck_noClient CHECK (noClient % 10 = 0),
	nom					VARCHAR(50),
	prenom				VARCHAR(50),
	ville				VARCHAR(100),
	pays				VARCHAR(50),
	adresse				VARCHAR(100),
	codePostal			VARCHAR(7),
	dateInscription		DATETIME,
	CONSTRAINT pk_client PRIMARY KEY (noClient) 
	);

print 'Création de la TABLE reservationChambre...'
CREATE TABLE reservationChambre (
	noClient			NUMERIC,
	noChambre			NUMERIC,
	dateArrive			DATETIME,
	dateDepart			DATETIME,
	nbPersonnes			NUMERIC,
	CONSTRAINT pk_reservationChambre PRIMARY KEY (noClient, noChambre, dateArrive),
	CONSTRAINT fk_client_reservationChambre FOREIGN KEY (noClient) REFERENCES client(noClient),
	CONSTRAINT fk_chambre FOREIGN KEY (noChambre) REFERENCES chambre(noChambre)
	);

print 'Création de la TABLE invite...'
CREATE TABLE invite (
	noInvite			NUMERIC CONSTRAINT ck_noInvite CHECK (noInvite % 10 != 0),
	nomPrenon			VARCHAR(100),
	noClient			NUMERIC,
	CONSTRAINT pk_invite PRIMARY KEY (noInvite),
	CONSTRAINT fk_client_invite FOREIGN KEY (noClient) REFERENCES client(noClient)
	);

print 'Création de la TABLE typeUtilisateur...'
CREATE TABLE typeUtilisateur (
	noTypeUtilisateur	NUMERIC,
	identification		VARCHAR(200),
	CONSTRAINT pk_typeUtilisateur PRIMARY KEY (noTypeUtilisateur)
	);

print 'Création de la TABLE utilisateur...'
CREATE TABLE utilisateur (
	noUtilisateur		NUMERIC,
	nomUtilisateur		VARCHAR(50) CONSTRAINT un_nomUtilisateur UNIQUE,
	mdpUtilisateur		VARCHAR(50),
	noTypeUtilisateur	NUMERIC,
	CONSTRAINT pk_utilisateur PRIMARY KEY (noUtilisateur),
	CONSTRAINT fk_typeUtilisateur FOREIGN KEY (noTypeUtilisateur) REFERENCES typeUtilisateur(noTypeUtilisateur)
	);