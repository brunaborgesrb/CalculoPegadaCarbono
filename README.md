# Desafio

Vamos desenvolver uma ferramenta para calcular a pegada de carbono de uma pessoa, dessa forma, crie variáveis como nome, quilometrosPorDia, horasDeEletronicos, refeicoesComCarne para armazenar as respectivas entradas do usuário. Para o cálculo da pegada, crie uma função CalcularPegadaDeCarbono que opera através da utilização de fatores de emissão específicos para cada atividade que contribui para a pegada de carbono, sendo eles:

quilometrosPorDia: fator de 0.2, é a média estimada das emissões de carbono associadas a veículos motorizados ao longo de um ano.

horasDeEletronicos, fator de 0.1, é a pegada de carbono relacionada ao consumo elétrico desses dispositivos.

refeicoesComCarne, fator de 0.5, é utilizado para representar as emissões associadas à produção de carne.

A pegada de carbono do usuário é calculada a partir de três fatores: transporte (quilômetros diários × 365 × 0.2), eletrônicos (horas diárias × 0.1) e consumo de carne (refeições com carne por dia × 0.5). A soma desses valores fornece a pegada de carbono total, abrangendo diversas fontes de emissões.
