# Extract Server Photos By Procedure

Aplicação Windows Form + C# para extração de fotos cadastradas em um banco de dados (normalmente para galerias criadas por N usuários), separando os arquivos por pasta e renomeando os mesmo (nome original guardado no banco ou um novo nome). Tudo baseado numa procedure que indica as informações necessárias e a url das imagens. 

## Prerequisites:

Visual Studio, SQL Server data base, Procedure

## ## Intalação:

Primeiramente, crie sua procedure retornando os seguintes dados:
string Pasta_DP: Nome da pasta onde a foto deve ser colocada após o download
string Caminho_Foto: Caminho até a foto no servidor
string Nome_Foto: Nome com que a foto deve ser salva

No arquivo “Conexao.cs”, insira as credenciais para o acesso ao seu banco de dados.

A procedure deve ser colocada no campo “Proc” na tela inicial da aplicação. 

## Testando:

Após configurar e criar procedure, rode a aplicação, serão exibidos um botão “Teste de conexão ao banco de dados” e outro “Testar os primeiros 10 registros da procedure”. 

## Executando

Existe uma caixa de texto onde é exibido o processo do download de foto por foto, também é possível salvar em um TXT esse log para uso posterior. 

Campos editáveis exibidos:
Tela principal:
URL: Caminho base do servidor
PROC: nome da procedure a ser executada
Salvar em: Caminho onde serão extraídas

## Referencias: 
http://splintersharp.blogspot.com.br/2010/08/criando-uma-classe-de-conexao-para-suas.html
Entre outras. 
