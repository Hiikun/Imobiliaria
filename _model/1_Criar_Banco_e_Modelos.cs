
/// Criar Tabelas Banco
 
/// Criar Stored Procedures
	- Selecionar
			PROCEDURE `SelecionarExemplo`(IN pfiltro VARCHAR(100))
			BEGIN
				IF (pfiltro = "") THEN 
					SELECT * FROM banco.exemplo;
				ELSE
					SELECT * FROM banco.exemplo; 
					WHERE	exemplo.exid			LIKE CONCAT('%',pfiltro,'%')
					OR		exemplo.exnascimento	LIKE CONCAT('%',pfiltro,'%')
				END IF;
			END

	- Inserir
			PROCEDURE `InserirExemplo` (IN pexnome VARCHAR(255), IN pexnascimento DATE)
			BEGIN
				INSERT INTO banco.exemplo
				(exnome, exnascimento)
				VALUES
				(pexnome, pexnascimento);
				SELECT exid FROM banco.exemplo
				WHERE exid = LAST_INSERT_ID();
			END

	- Alterar
			PROCEDURE `AlterarExemplo`(IN pexid INT, IN pexnome VARCHAR(255), IN pexnascimento DATE)
			BEGIN
				UPDATE banco.exemplo
				SET exnome = pexnome, exnascimento = pexnascimento
				WHERE exid = pexid;
			END

	- Excluir
			PROCEDURE `ExcluirExemplo`(IN pexid INT)
			BEGIN
				DELETE FROM banco.exemplo WHERE exid = pexid;
			END

	
///  Criar Biblioteca de Classes Modelos 
	
		// Criar Classe Modelo do Objeto
			
				namespace Projeto.nome_da_biblioteca;
				public class ExemploModelo
				{
					public int Id { get; set; }
					public string Variavel { get; set; }
				}
			

		// Criar Classe Lista do "Modelo do Objeto"
			
				namespace Projeto.nome_da_biblioteca;
				public class ExemploLista : List<ExemploModelo>
				{

				}
			






	
