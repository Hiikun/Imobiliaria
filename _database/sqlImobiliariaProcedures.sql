-- -----------------------------------------------------
-- Procedures `imobiliaria`.`clientes`
-- -----------------------------------------------------

-- Selecionar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ClientesSelecionar`;;
        CREATE PROCEDURE `ClientesSelecionar`(IN pfiltro VARCHAR(100))
        BEGIN
            IF (pfiltro = "") THEN 
                SELECT * FROM `imobiliaria`.`clientes`;
            ELSE
                SELECT * FROM `imobiliaria`.`clientes`
                WHERE	`clientes`.id_cliente			LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.nome_cliente			LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.cpf					LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.rg					LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.endereco_completo	LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.cep					LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.telefone1			LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.telefone2			LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.email				LIKE CONCAT('%',pfiltro,'%')
                OR		`clientes`.dt_nascimento		LIKE CONCAT('%',pfiltro,'%');
            END IF;
        END;;
        DELIMITER ;

-- Inserir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ClientesInserir`;;
        CREATE PROCEDURE `ClientesInserir` (IN pclinome_cliente VARCHAR(255), IN pclicpf VARCHAR(15), IN pclirg VARCHAR(15), IN pcliendereco_completo TEXT, IN pclicep VARCHAR(9), IN pclitelefone1 VARCHAR(15), IN pclitelefone2 VARCHAR(15), IN pcliemail VARCHAR(50), IN pclidt_nascimento VARCHAR(50))
        BEGIN
            INSERT INTO `imobiliaria`.`clientes`
            (nome_cliente, cpf, rg, endereco_completo, cep, telefone1, telefone2, email, dt_nascimento)
            VALUES
            (pclinome_cliente, pclicpf, pclirg, pcliendereco_completo, pclicep, pclitelefone1, pclitelefone2, pcliemail, pclidt_nascimento);
            SELECT id_cliente FROM `imobiliaria`.`clientes`
            WHERE id_cliente = LAST_INSERT_ID();
        END;;

-- Alterar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ClientesAlterar`;;
        CREATE PROCEDURE `ClientesAlterar`(IN pcliid_cliente SMALLINT, IN pclinome_cliente VARCHAR(255), IN pclicpf VARCHAR(15), IN pclirg VARCHAR(15), IN pcliendereco_completo TEXT, IN pclicep VARCHAR(9), IN pclitelefone1 VARCHAR(15), IN pclitelefone2 VARCHAR(15), IN pcliemail VARCHAR(50), IN pclidt_nascimento VARCHAR(50))
        BEGIN
            UPDATE `imobiliaria`.`clientes`
            SET nome_cliente = pclinome_cliente, cpf = pclicpf , rg = pclirg, endereco_completo = pcliendereco_completo, cep = pclicep, telefone1 = pclitelefone1, telefone2 = pclitelefone2, email = pcliemail, dt_nascimento = pclidt_nascimento
            WHERE id_cliente = pcliid_cliente;
        END;;
        DELIMITER ;

-- Excluir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ClientesExcluir`;;
        CREATE PROCEDURE `ClientesExcluir`(IN pcliid_cliente SMALLINT)
        BEGIN
            DELETE FROM `imobiliaria`.`clientes` WHERE id_cliente = pcliid_cliente;
        END;;
        DELIMITER ;
        
        
-- -----------------------------------------------------
-- Procedures `imobiliaria`.`imoveis`
-- -----------------------------------------------------

-- Selecionar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ImoveisSelecionar`;;
        CREATE PROCEDURE `ImoveisSelecionar`(IN pfiltro VARCHAR(100))
        BEGIN
            IF (pfiltro = "") THEN 
                SELECT * FROM `imobiliaria`.`imoveis`;
            ELSE
                SELECT * FROM `imobiliaria`.`imoveis`
                WHERE	`imoveis`.id_imovel		          	LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.id_imovel			    	LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.id_cliente				LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.nome_imovel				LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.endereco			    	LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.bairro					LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.zona_cidade				LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.cep						LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.tipo_imovel				LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.condominio				LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.metragem			    	LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.dormitorios				LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.banheiros			    	LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.suites					LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.vagas_garagem			    LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.valor_aluguel_sugerido	LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.valor_iptu				LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.requisitos_inquilino  	LIKE CONCAT('%',pfiltro,'%')
                OR		`imoveis`.obs						LIKE CONCAT('%',pfiltro,'%');
            END IF;
        END;;
        DELIMITER ;

-- Inserir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ImoveisInserir`;;
        CREATE PROCEDURE `ImoveisInserir` (IN pid_cliente SMALLINT(6), IN pnome_imovel VARCHAR(256), IN pendereco TEXT, IN pbairro VARCHAR(45), IN pzona_cidade VARCHAR(10), IN pcep VARCHAR(9), IN ptipo_imovel VARCHAR(256), IN pcondominio BIT ,IN pmetragem DECIMAL(10,2), IN pdormitorios TINYINT(4), IN pbanheiros TINYINT(4), IN psuites TINYINT(4), IN pvagas_garagem TINYINT(4), IN pvalor_aluguel_sugerido	DECIMAL(10,2), IN pvalor_iptu DECIMAL(10,2), IN prequisitos_inquilino TEXT, IN pobs TEXT)
        BEGIN
            INSERT INTO `imobiliaria`.`imoveis`
            (id_cliente, nome_imovel, endereco, bairro, zona_cidade, cep, tipo_imovel, condominio, metragem, dormitorios, banheiros, suites, vagas_garagem, valor_aluguel_sugerido, valor_iptu, requisitos_inquilino, obs)
            VALUES
            (pid_cliente, pnome_imovel, pendereco, pbairro, pzona_cidade, pcep, ptipo_imovel, pcondominio, pmetragem, pdormitorios, pbanheiros, psuites, pvagas_garagem, pvalor_aluguel_sugerido, pvalor_iptu, prequisitos_inquilino, pobs);
            SELECT id_imovel FROM `imobiliaria`.`imoveis`
            WHERE id_imovel = LAST_INSERT_ID();
        END;;

-- Alterar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ImoveisAlterar`;;
        CREATE PROCEDURE `ImoveisAlterar`(IN pid_imovel SMALLINT(6), IN pid_cliente SMALLINT(6), IN pnome_imovel VARCHAR(256), IN pendereco TEXT, IN pbairro VARCHAR(45), IN pzona_cidade VARCHAR(10), IN pcep VARCHAR(9), IN ptipo_imovel VARCHAR(256), IN pcondominio BIT ,IN pmetragem DECIMAL(10,2), IN pdormitorios TINYINT(4), IN pbanheiros TINYINT(4), IN psuites TINYINT(4), IN pvagas_garagem TINYINT(4), IN pvalor_aluguel_sugerido	DECIMAL(10,2), IN pvalor_iptu DECIMAL(10,2), IN prequisitos_inquilino TEXT, IN pobs TEXT)
        BEGIN
            UPDATE `imobiliaria`.`imoveis`
            SET id_cliente = pid_cliente, nome_imovel = pnome_imovel, endereco = pendereco, bairro = pbairro, zona_cidade = pzona_cidade, cep = pcep, tipo_imovel = ptipo_imovel, condominio = pcondominio, metragem = pmetragem, dormitorios = pdormitorios, banheiros = pbanheiros, suites = psuites, vagas_garagem = pvagas_garagem, valor_aluguel_sugerido = pvalor_aluguel_sugerido, valor_iptu = pvalor_iptu, requisitos_inquilino = prequisitos_inquilino, obs = pobs 
            WHERE id_imovel = pid_imovel;
        END;;
        DELIMITER ;

-- Excluir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ImoveisExcluir`;;
        CREATE PROCEDURE `ImoveisExcluir`(IN pid_imovel SMALLINT(6))
        BEGIN
            DELETE FROM `imobiliaria`.`imoveis` WHERE id_imovel = pid_imovel;
        END;;
        DELIMITER ;
        
        
-- -----------------------------------------------------
-- Procedures `imobiliaria`.`locacao`
-- -----------------------------------------------------

-- Selecionar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `LocacaoSelecionar`;;
        CREATE PROCEDURE `LocacaoSelecionar`(IN pfiltro VARCHAR(100))
        BEGIN
            IF (pfiltro = "") THEN 
                SELECT * FROM `imobiliaria`.`locacao`;
            ELSE
                SELECT * FROM `imobiliaria`.`locacao`
                WHERE	`locacao`.id_locacao				LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.id_imovel					LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.id_inquilino				LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.id_advogado				LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.valor_aluguel				LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.periodicidade				LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.percentual_multa			LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.dia_vencimento			LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.data_inicio				LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.data_fim					LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.ativo						LIKE CONCAT('%',pfiltro,'%')	
                OR		`locacao`.responsavel_pagamento		LIKE CONCAT('%',pfiltro,'%')
                OR		`locacao`.obs						LIKE CONCAT('%',pfiltro,'%');
            END IF;
        END;;
        DELIMITER ;

-- Inserir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `LocacaoInserir`;;
        CREATE PROCEDURE `LocacaoInserir` (IN pid_imovel SMALLINT(6), IN pid_inquilino SMALLINT(6), IN pid_advogado SMALLINT(6), IN pvalor_aluguel DECIMAL(10,4), IN pperiodicidade VARCHAR(10), IN ppercentual_multa DECIMAL(5,2), IN pdia_vencimento TINYINT(4), IN pdata_inicio DATE, IN pdata_fim DATE, IN pativo BIT(1), IN presponsavel_pagamento VARCHAR(45), IN pobs TEXT)
        BEGIN
            INSERT INTO `imobiliaria`.`locacao`
            (id_imovel, id_inquilino, id_advogado, valor_aluguel, periodicidade, percentual_multa, dia_vencimento, data_inicio, data_fim, ativo, responsavel_pagamento, obs)
            VALUES
            (pid_imovel, pid_inquilino, pid_advogado, pvalor_aluguel, pperiodicidade, ppercentual_multa, pdia_vencimento, pdata_inicio, pdata_fim, pativo, presponsavel_pagamento, pobs);
            SELECT id_locacao FROM `imobiliaria`.`locacao`
            WHERE id_locacao = LAST_INSERT_ID();
        END;;

-- Alterar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `LocacaoAlterar`;;
        CREATE PROCEDURE `LocacaoAlterar`(IN pid_locacao INT, IN pid_imovel SMALLINT(6), IN pid_inquilino SMALLINT(6), IN pid_advogado SMALLINT(6), IN pvalor_aluguel DECIMAL(10,4), IN pperiodicidade VARCHAR(10), IN ppercentual_multa DECIMAL(5,2), IN pdia_vencimento TINYINT(4), IN pdata_inicio DATE, IN pdata_fim DATE, IN pativo BIT(1), IN presponsavel_pagamento VARCHAR(45), IN pobs TEXT)
        BEGIN
            UPDATE `imobiliaria`.`locacao`
            SET id_imovel = pid_imovel, id_inquilino = pid_inquilino, id_advogado = pid_advogado, valor_aluguel = pvalor_aluguel, periodicidade = pperiodicidade, percentual_multa = ppercentual_multa, dia_vencimento =pdia_vencimento, data_inicio = pdata_inicio, data_fim = pdata_fim, ativo = pativo, responsavel_pagamento = presponsavel_pagamento, obs = pobs
            WHERE id_locacao = pid_locacao;
        END;;
        DELIMITER ;

-- Excluir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `LocacaoExcluir`;;
        CREATE PROCEDURE `LocacaoExcluir`(IN pid_locacao SMALLINT(6))
        BEGIN
            DELETE FROM `imobiliaria`.`locacao` WHERE id_locacao = pid_locacao;
        END;;
        DELIMITER ;



-- -----------------------------------------------------
-- Procedures `imobiliaria`.`alugueis`
-- -----------------------------------------------------

-- Selecionar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `AlugueisSelecionar`;;
        CREATE PROCEDURE `AlugueisSelecionar`(IN pfiltro VARCHAR(100))
        BEGIN
            IF (pfiltro = "") THEN 
                SELECT * FROM `imobiliaria`.`alugueis`;
            ELSE
                SELECT * FROM `imobiliaria`.`alugueis`
                WHERE	id_locacao      LIKE CONCAT('%',pfiltro,'%')
                OR		data_vencimento LIKE CONCAT('%',pfiltro,'%')
                OR		valor_pago      LIKE CONCAT('%',pfiltro,'%')
                OR		data_pagamento  LIKE CONCAT('%',pfiltro,'%')
                OR		obs             LIKE CONCAT('%',pfiltro,'%');
            END IF;
        END;;
        DELIMITER ;

-- Inserir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `AlugueisInserir`;;
        CREATE PROCEDURE `AlugueisInserir` (IN pid_locacao INT(11), IN pdata_vencimento DATE, IN pvalor_pago DECIMAL(10,2), IN pdata_pagamento DATE, IN pobs TEXT)
        BEGIN
            INSERT INTO `imobiliaria`.`alugueis`
            (id_locacao, data_vencimento, valor_pago, data_pagamento, obs)
            VALUES
            (pid_locacao, pdata_vencimento, pvalor_pago, pdata_pagamento, pobs);
        END;;

-- Alterar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `AlugueisAlterar`;;
        CREATE PROCEDURE `AlugueisAlterar`(IN pid_locacao INT(11), IN pdata_vencimento DATE, IN pvalor_pago DECIMAL(10,2), IN pdata_pagamento DATE, IN pobs TEXT)
        BEGIN
            UPDATE `imobiliaria`.`alugueis`
            SET valor_pago = pvalor_pago, data_pagamento = pdata_pagamento, obs = pobs
            WHERE id_locacao = pid_locacao
            AND data_vencimento = pdata_vencimento;
        END;;
        DELIMITER ;

-- Excluir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `AlugueisExcluir`;;
        CREATE PROCEDURE `AlugueisExcluir`(IN pid_locacao TINYINT(6), IN pdata_vencimento DATE)
        BEGIN
            DELETE FROM `imobiliaria`.`alugueis` WHERE id_locacao = pid_locacao AND data_vencimento = pdata_vencimento;
        END;;
        DELIMITER ;



-- -----------------------------------------------------
-- Procedures `imobiliaria`.`profissionais`
-- -----------------------------------------------------

-- Selecionar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ProfissionaisSelecionar`;;
        CREATE PROCEDURE `ProfissionaisSelecionar`(IN pfiltro VARCHAR(100))
        BEGIN
            IF (pfiltro = "") THEN 
                SELECT * FROM `imobiliaria`.`profissionais`;
            ELSE
                SELECT * FROM `imobiliaria`.`profissionais`
                WHERE	`profissionais`.id_profissional	LIKE CONCAT('%',pfiltro,'%')
                OR		`profissionais`.nome			LIKE CONCAT('%',pfiltro,'%')
                OR		`profissionais`.profissao		LIKE CONCAT('%',pfiltro,'%')
                OR		`profissionais`.telefone1		LIKE CONCAT('%',pfiltro,'%')
                OR		`profissionais`.telefone2		LIKE CONCAT('%',pfiltro,'%')
                OR		`profissionais`.valor_hora		LIKE CONCAT('%',pfiltro,'%')
                OR		`profissionais`.obs				LIKE CONCAT('%',pfiltro,'%');
            END IF;
        END;;
        DELIMITER ;

-- Inserir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ProfissionaisInserir`;;
        CREATE PROCEDURE `ProfissionaisInserir` (IN pnome VARCHAR(45), IN pprofissao VARCHAR(45), IN ptelefone1 VARCHAR(15), IN ptelefone2 VARCHAR(15), IN pvalor_hora DECIMAL(10,2), IN pobs TEXT)
        BEGIN
            INSERT INTO `imobiliaria`.`profissionais`
            (nome, profissao, telefone1, telefone2, valor_hora, obs)
            VALUES
            (pnome, pprofissao, ptelefone1, ptelefone2, pvalor_hora, pobs);
            SELECT id_profissional FROM `imobiliaria`.`profissionais`
            WHERE id_profissional = LAST_INSERT_ID();
        END;;

-- Alterar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ProfissionaisAlterar`;;
        CREATE PROCEDURE `ProfissionaisAlterar`(IN pid_profissional SMALLINT(6), IN pnome VARCHAR(45), IN pprofissao VARCHAR(45), IN ptelefone1 VARCHAR(15), IN ptelefone2 VARCHAR(15), IN pvalor_hora DECIMAL(10,2), IN pobs TEXT)
        BEGIN
            UPDATE `imobiliaria`.`profissionais`
            SET nome = pnome, profissao = pprofissao, telefone1 = ptelefone1, telefone2 = ptelefone2, valor_hora = pvalor_hora, obs = pobs
            WHERE id_profissional = pid_profissional;
        END;;
        DELIMITER ;

-- Excluir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `ProfissionaisExcluir`;;
        CREATE PROCEDURE `ProfissionaisExcluir`(IN pid_profissional SMALLINT(6))
        BEGIN
            DELETE FROM `imobiliaria`.`profissionais` WHERE id_profissional = pid_profissional;
        END;;
        DELIMITER ;



-- -----------------------------------------------------
-- Procedures `imobiliaria`.`servicos_imovel`
-- -----------------------------------------------------

-- Selecionar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `Servicos_imovelSelecionar`;;
        CREATE PROCEDURE `Servicos_imovelSelecionar`(IN pfiltro VARCHAR(100))
        BEGIN
            IF (pfiltro = "") THEN 
                SELECT * FROM `imobiliaria`.`servicos_imovel`;
            ELSE
                SELECT * FROM `imobiliaria`.`servicos_imovel`
                    WHERE   id_imovel LIKE CONCAT('%',pfiltro,'%');
            END IF;
        END;;
        DELIMITER ;

-- Inserir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `Servicos_imovelInserir`;;
        CREATE PROCEDURE `Servicos_imovelInserir` (IN pid_profissional SMALLINT(6), IN pid_imovel SMALLINT(6), IN pdata_servico VARCHAR(50), IN pvalor_total DECIMAL(10,2), IN pobs TEXT)
        BEGIN
            INSERT INTO `imobiliaria`.`servicos_imovel`
            (id_profissional, id_imovel, data_servico, valor_total, obs)
            VALUES
            (pid_profissional, pid_imovel, pdata_servico, pvalor_total, pobs);
            SELECT id_trabalho FROM `imobiliaria`.`servicos_imovel`
            WHERE id_trabalho = LAST_INSERT_ID();
        END;;

-- Alterar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `Servicos_imovelAlterar`;;
        CREATE PROCEDURE `Servicos_imovelAlterar`(IN pid_trabalho SMALLINT(6), IN pid_profissional SMALLINT(6), IN pid_imovel SMALLINT(6), IN pdata_servico VARCHAR(50), IN pvalor_total DECIMAL(10,2), IN pobs TEXT)
        BEGIN
            UPDATE `imobiliaria`.`servicos_imovel`
            SET id_profissional = pid_profissional, id_imovel = pid_imovel, data_servico = pdata_servico, valor_total = pvalor_total, obs = pobs
            WHERE id_trabalho = pid_trabalho;
        END;;
        DELIMITER ;

-- Excluir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `Servicos_imovelExcluir`;;
        CREATE PROCEDURE `Servicos_imovelExcluir`(IN pid_trabalho SMALLINT(6))
        BEGIN
            DELETE FROM `imobiliaria`.`servicos_imovel` WHERE id_trabalho = pid_trabalho;
        END;;
        DELIMITER ;



-- -----------------------------------------------------
-- Procedures `imobiliaria`.`FUNCIONARIOS`
-- -----------------------------------------------------

-- Autenticar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `FuncionarioAutenticar`;;
		CREATE DEFINER=`root`@`localhost` PROCEDURE `FuncionarioAutenticar`(IN pfunlogin VARCHAR(16), IN pfunsenha VARCHAR(32), IN pfuntipo VARCHAR(15))
		BEGIN
			SELECT funlogin, funsenha, funtipo FROM imobiliaria.funcionarios WHERE funlogin = pfunlogin AND funsenha = pfunsenha AND funtipo = pfuntipo;
		END ;;
		DELIMITER ;

-- Selecionar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `FuncionarioSelecionar`;;
		CREATE DEFINER=`root`@`localhost` PROCEDURE `FuncionarioSelecionar`(IN pfiltro VARCHAR(100))
		BEGIN
			IF(pfiltro = "") THEN
				SELECT * FROM Imobiliaria.funcionarios;
			ELSE
				SELECT * FROM Imobiliaria.funcionarios 
				WHERE funcionarios.funid LIKE CONCAT('%', pfiltro, '%')
				OR funcionarios.funnome LIKE CONCAT('%', pfiltro, '%')
				OR funcionarios.funlogin LIKE CONCAT('%', pfiltro, '%')
                OR funcionarios.funsenha LIKE CONCAT('%', pfiltro, '%')
				OR funcionarios.funtipo LIKE CONCAT('%', pfiltro, '%');
			END IF;
		END ;;
		DELIMITER ;

-- Inserir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `FuncionarioInserir`;;
		CREATE DEFINER=`root`@`localhost` PROCEDURE `FuncionarioInserir`(IN pfunnome VARCHAR(100), IN pfunlogin VARCHAR(16), IN pfunsenha VARCHAR(32), IN pfuntipo VARCHAR(15))
		BEGIN
			INSERT INTO Imobiliaria.funcionarios
			(funnome, funlogin, funsenha, funtipo)
			VALUES
			(pfunnome, pfunlogin, pfunsenha, pfuntipo);
			SELECT * FROM imobiliaria.funcionarios
			WHERE funid = LAST_INSERT_ID();
		END ;;
		DELIMITER ;

-- Alterar
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `FuncionarioAlterar`;;
		CREATE DEFINER=`root`@`localhost` PROCEDURE `FuncionarioAlterar`(IN pfunid INT, IN pfunnome VARCHAR(100), IN pfunlogin VARCHAR(16), IN pfunsenha VARCHAR(32), IN pfuntipo VARCHAR(15))
		BEGIN
			UPDATE `Imobiliaria`.`funcionarios`
			SET funnome = pfunnome, funlogin = pfunlogin, funsenha = pfunsenha, funtipo = pfuntipo
			WHERE funid = pfunid;
		END ;;
		DELIMITER ;

-- Excluir
		DELIMITER ;;
		DROP PROCEDURE IF EXISTS `FuncionarioExcluir`;;
		CREATE DEFINER=`root`@`localhost` PROCEDURE `FuncionarioExcluir`(IN pfunid INT)
		BEGIN
			DELETE FROM Imobiliaria.funcionarios WHERE funid = pfunid;
		END ;;
		DELIMITER ;
        
        