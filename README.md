# Respostas-Target

1) Observe o trecho de código abaixo:

```

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);


```
Ao final do processamento, qual será o valor da variável SOMA?

91


2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

Código nos arquivos

3) Descubra a lógica e complete o próximo elemento:


a) 1, 3, 5, 7, <strong><code>9</code></strong> (Sequência de números ímpares.)

b) 2, 4, 8, 16, 32, 64,  <strong><code>128</code></strong> (O próximo número após 64, ao ser dobrado, resulta em 128.)

c) 0, 1, 4, 9, 16, 25, 36, <strong><code>49</code></strong> (Sequência de quadrados dos números naturais.)

d) 4, 16, 36, 64, <strong><code>100</code></strong> (Sequência de quadrados dos números pares, sendo o  quadrado de 10 o próximo.)

e) 1, 1, 2, 3, 5, 8,<strong><code>13</code></strong> (Sequência de Fibonacci.)

f) 2,10, 12, 16, 17, 18, 19, <strong><code>200</code></strong> (Sequência formada através de todos os números que iniciam com a letra d. Assim, o próximo número em ordem crescente que inicia com a letra d é 200.)


4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

R: Considerando que é possível tocar nas lâmpadas, ligarei o primeiro interruptor e deixarei por um tempo suficiente para até uma lampada led esquentar, depois desligo e ligo o segundo interruptor.
Farei a primeira ida a uma sala imediatamente:
-Se a lâmpada estiver acesa, o segundo interruptor controla essa lâmpada.
-Se a lâmpada estiver apagada e estiver fria, o terceiro interruptor controla essa lâmpada.
-Se a lâmpada estiver apagada, mas estiver quente, o primeiro interruptor controla essa lâmpada.

Voltando aos interruptores após descobrir qual interruptor controla aquela sala 1, excluo esse interruptor e ligo um dos dois restantes para esquentar e depois desligo ligo o último, vou até a sala 2 e repito o processo, após descobrir o dessa segunda sala, o que sobrar controla o da terceira pela lógica de eliminação.  Se não for possível tocar nas lâmpadas para avaliar temperatura, será necessário 3 idas.

5) Escreva um programa que inverta os caracteres de um string.
Código nos arquivos
