CREATE TABLE Estado (
    IDEstado INT PRIMARY KEY AUTO_INCREMENT,
    NomeEstado VARCHAR(50),
    UF CHAR(2)
);

CREATE TABLE Cliente (
    IDCliente INT PRIMARY KEY AUTO_INCREMENT,
    RazaoSocial VARCHAR(100),
    IDEstado INT,
    FOREIGN KEY (IDEstado) REFERENCES Estado(IDEstado)
);

CREATE TABLE TipoTelefone (
    IDTipoTelefone CHAR(3) PRIMARY KEY,
    DescricaoCompleta VARCHAR(20)
);

CREATE TABLE Telefone (
    IDTelefone INT PRIMARY KEY AUTO_INCREMENT,
    NumeroTelefone VARCHAR(15),
    IDCliente INT,
    IDTipoTelefone CHAR(3), 
    FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente), 
    FOREIGN KEY (IDTipoTelefone) REFERENCES TipoTelefone(IDTipoTelefone)
);

-- TipoTelefone
INSERT INTO TipoTelefone (IDTipoTelefone, DescricaoCompleta)
VALUES
('C', 'Celular'),
('R', 'Residencial'),
('W', 'WhatsApp'),
('CM', 'Comercial');

-- Inserir Estado
INSERT INTO Estado (NomeEstado, UF)
VALUES
('São Paulo', 'SP'),
('Rio de Janeiro', 'RJ'),
('Minas Gerais', 'MG'),
('Brasília', 'DF');

-- Inserir Cliente
INSERT INTO Cliente (RazaoSocial, IDEstado) VALUES ('Cobasi', 1);
INSERT INTO Cliente (RazaoSocial, IDEstado) VALUES ('Dell', 1);
INSERT INTO Cliente (RazaoSocial, IDEstado) VALUES ('Sony', 3);
INSERT INTO Cliente (RazaoSocial, IDEstado) VALUES ('Acer', 2);


-- Telefone Cobasi (IDCliente = 1)
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('11987654321', 1, 'C');  
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('1132323232', 1, 'CM');  

-- Telefone Dell (IDCliente = 2)
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('11999999999', 2, 'R');  
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('1144444444', 2, 'W');   

-- Telefone Sony (IDCliente = 3)
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('61912345678', 3, 'C');  
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('6133333333', 3, 'CM');  

-- Telefone Acer (IDCliente = 4)
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('21987654321', 4, 'C');  
INSERT INTO Telefone (NumeroTelefone, IDCliente, IDTipoTelefone) VALUES ('2145323232', 4, 'R');  

SELECT 
    c.IDCliente AS CodigoCliente, 
    c.RazaoSocial, 
    t.NumeroTelefone
FROM 
    Cliente c
JOIN 
    Estado e ON c.IDEstado = e.IDEstado
JOIN 
    Telefone t ON c.IDCliente = t.IDCliente
WHERE 
    e.UF = 'SP';
