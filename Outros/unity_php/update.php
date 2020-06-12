<?php 
	//Cria as constantes com informações do BD
	define('HOST', 'localhost' );	
	define('USER', 'root' );	
	define('PASSWORD', '' );	
	define('DB_NAME', 'unity' );
	
	//Cria a classe que vai manipular dados do Unity
	class Unity{
	
		//Cria o método que abre a conexão com o BD
		public function abreConexao(){						
			try{				
				$PDO = new PDO('mysql:host='.HOST.';dbname='.DB_NAME, USER, PASSWORD );
				$PDO->exec("set names utf8");
				return $PDO;
				
			}catch (PDOException $e)
			{
				//Retorna o erro
				echo $e->getMessage();
			}
		}
		
		//Cria o método que fecha a conexão com o BD
		public function closeConn(){			
			$PDO = $this->abreConexao();
			$PDO = null;	
		}	
		
		//Cria os atributos da classe
		private $pontos;
		private $cena;
		private $id;

		//Cria os métodos set
		public function setId($i){
			$this->id = $i;
		}
		
		public function setPontos($p){
			$this->pontos = $p;
		}
		
		public function setCena($c){
			$this->cena = $c;
		}
		
		//Cria os métodos get
		public function getId(){
			return $this->id;
		}
		
		public function getPontos(){
			return $this->pontos;
		}
		
		public function getCena(){
			return $this->cena;
		}
		
		//Cria o método atualiza as informações do player
		public function updateCena(){
			//Abre a conexao
			$PDO = $this->abreConexao();
			
			//Cria a declaração SQL
			$sql = 'UPDATE login SET ';
			$sql .= 'cena = :cena,';
			$sql .= 'pontos = :pontos';
			$sql .= ' WHERE id = :id';
			
			//Prepara a execução do comando	
			$stmt = $PDO->prepare($sql);			
			
			//Recebe os valores dos atributos
			$stmt->bindParam(':cena', $this->getCena());
			$stmt->bindParam(':pontos', $this->getPontos());
			$stmt->bindParam(':id', $this->getId());
			
			//Executa o comando
			$result = $stmt->execute();
			
			//Fecha a conexão	
			$this->closeConn();
			
			//Verifica o resultado da operação no BD
			if (!$result){
				//Imprime o erro e sai
				var_dump($stmt->errorInfo());
				exit;
			}else{
				//Exibe a mensagem de sucesso
				echo "ok";
			}
		}		
	}
	
	//Instancia a classe
	$dados = new Unity();
	
	//Recebe as informações do Unity
	$cenaRecebida = $_REQUEST['userCena'];	
	$pontosRecebidos = $_REQUEST['userPontos'];	
	$idRecebido = $_REQUEST['userID'];
	
	//Passa os dados para os atributos
	$dados->setId($idRecebido);
	$dados->setCena($cenaRecebida);
	$dados->setPontos($pontosRecebidos);
	
	//Chama o método que atualiza os dados
	$dados->updateCena();	
?>