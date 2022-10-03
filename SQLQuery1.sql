SELECT * FROM tbMoeda;

ALTER TABLE tbMoeda ADD Cod_moeda_API VARCHAR (3);

UPDATE tbMoeda SET Cod_moeda_API = 'USD' WHERE Simbolo_moeda = 'U$';
UPDATE tbMoeda SET Cod_moeda_API = 'EUR' WHERE Simbolo_moeda = 'EU$';
UPDATE tbMoeda SET Cod_moeda_API = 'ARS' WHERE Simbolo_moeda = 'P$';
UPDATE tbMoeda SET Cod_moeda_API = 'PYG' WHERE Simbolo_moeda = 'G$';
UPDATE tbMoeda SET Cod_moeda_API = 'BRL' WHERE Simbolo_moeda = 'R$';
UPDATE tbMoeda SET Cod_moeda_API = 'GBP' WHERE Simbolo_moeda = 'LB$';

SELECT Cod_moeda FROM tbMoeda WHERE Cod_moeda_API = 'EUR'

