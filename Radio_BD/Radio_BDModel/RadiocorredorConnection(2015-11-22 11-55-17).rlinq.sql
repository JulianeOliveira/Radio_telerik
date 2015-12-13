-- Radio_BDModel.Avaliacao
CREATE TABLE `avaliacao` (
    `id_programa` integer NULL,             -- _programa
    `nota` nvarchar(45) NULL,               -- _nota
    `id` integer AUTO_INCREMENT NOT NULL,   -- _id
    `comentario` nvarchar(45) NULL,         -- _comentario
    `id_ouvinte` integer NULL,              -- _cadastro_usuario
    CONSTRAINT `pk_avaliacao` PRIMARY KEY (`id`)
) ENGINE = InnoDB;

-- Radio_BDModel.Cadastro_usuario
CREATE TABLE `cadastro_usuario` (
    `senha` nvarchar(45) NULL,              -- _senha
    `nome` nvarchar(45) NULL,               -- _nome
    `id` integer AUTO_INCREMENT NOT NULL,   -- _id
    `email` nvarchar(45) NULL,              -- _email
    `cpf` nvarchar(45) NULL,                -- _cpf
    CONSTRAINT `pk_cadastro_usuario` PRIMARY KEY (`id`)
) ENGINE = InnoDB;

-- Radio_BDModel.Pedido_musica
CREATE TABLE `pedido_musica` (
    `nome_musica` nvarchar(45) NULL,        -- _nome_musica
    `id` integer AUTO_INCREMENT NOT NULL,   -- _id
    `data` date NULL,                       -- _data
    `id_ouvinte` integer NOT NULL,          -- _cadastro_usuario
    CONSTRAINT `pk_pedido_musica` PRIMARY KEY (`id`)
) ENGINE = InnoDB;

-- Radio_BDModel.Programa
CREATE TABLE `programa` (
    `nome_programa` nvarchar(45) NULL,      -- _nome_programa
    `id` integer AUTO_INCREMENT NOT NULL,   -- _id
    `hora` time NULL,                       -- _hora
    `descricao` nvarchar(45) NULL,          -- _descricao
    `apresentador` nvarchar(45) NULL,       -- _apresentador
    CONSTRAINT `pk_programa` PRIMARY KEY (`id`)
) ENGINE = InnoDB;

ALTER TABLE `avaliacao` ADD INDEX `fk_programa_idx`(`id_programa`);

ALTER TABLE `avaliacao` ADD INDEX `fk_ouvinte_idx`(`id_ouvinte`);

ALTER TABLE `pedido_musica` ADD INDEX `fk_musica_idx`(`id_ouvinte`);

ALTER TABLE `avaliacao` ADD CONSTRAINT `fk_ouvinte` FOREIGN KEY `fk_ouvinte` (`id_ouvinte`) REFERENCES `cadastro_usuario` (`id`);

ALTER TABLE `avaliacao` ADD CONSTRAINT `fk_programa` FOREIGN KEY `fk_programa` (`id_programa`) REFERENCES `programa` (`id`);

ALTER TABLE `pedido_musica` ADD CONSTRAINT `fk_musica` FOREIGN KEY `fk_musica` (`id_ouvinte`) REFERENCES `cadastro_usuario` (`id`);

