use BD5B6TP1_BrodeurLussier;
print  'Insertion des données d''essai============================================='

print 'Insertion des rangées dans le table typeSoin...'
INSERT INTO typeSoin VALUES (1, 'Beauté');
INSERT INTO typeSoin VALUES (2, 'Santé');

print 'Insertion des rangées dans le table typeUtilisateur...'
INSERT INTO typeUtilisateur VALUES (1, 'Admin');
INSERT INTO typeUtilisateur VALUES (2, 'Préposé');

print 'Insertion des rangées dans le table utilisateur...'
INSERT INTO utilisateur VALUES (1, 'adm', 'adm1234', 1);
INSERT INTO utilisateur VALUES (2, 'prep', 'prep1234', 2);