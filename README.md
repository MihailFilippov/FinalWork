# FinalWork

## Задание:

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## Описание:

Обьявляются 2 массива:

* 1 - Массив заполненый данными
* 2 - Массив такого же размера

в методе __*ChekSrting*__ через цикл __*for*__, проверяется элемент 1-го массива на кол-во символов, при соблюдении условий (элемент состоит из 3-х и менее символов) он записывается во 2-ой массив на позицию __*count*__, после этого __*count*__ увеличивается на 1

В файле **Diagram.png** вы увидите блок-схему метода __*ChekSrting*__

Сам алгоритм находится Example001/Program.cs
