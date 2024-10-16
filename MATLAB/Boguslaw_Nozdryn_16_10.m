% ZAD 1: Napisz skrypt, który dla wprowadzonej liczby wydaje komentarz czy liczba jest dodatnia, 
% ujemna czy jest zerem.

number = input('Podaj liczbę: ');

if number > 0
    disp('Liczba jest dodatnia.');
elseif number < 0
    disp('Liczba jest ujemna.');
else
    disp('Liczba jest zerem.');
end

% ZAD 2: Wprowadź liczbę. Za pomocą instrukcji if przypisz liczbie wartość 0, 
% jeżeli liczba będzie mniejsza lub równa 4 oraz wartość 1 jeżeli będzie większa od 4.

number = input('Podaj liczbę: ');

if number <= 4
    number = 0;
else
    number = 1;
end

fprintf('Liczba: %d\n', number);

% ZAD3: Obliczyć wartość funkcji podanej wzorem z klamrą dla przyjętej wartości x

number = input('Podaj liczbę: ');

switch number
    case number < 3
      fprintf('Wynik: %d\n', number - 1);
    case (number > 3 && number < 7) 
      fprintf('Wynik: %d\n', number * sin(number));
   otherwise
      fprintf('Wynik: %d\n',1 / (pow2(number) + 1));
end

% ZAD4: Napisz skrypt obliczający równanie kwadratowe. Użytkownik podaje a, b, c gdzie 𝑎𝑥^2+𝑏𝑥+𝑐=0.
% Rozważ przypadki, gdy powyższy układ staje się liniowy (z jednym rozwiązaniem), 
% sprzecznym lub tożsamościowym.

a = input('Podaj a: ');
b = input('Podaj b: ');
c = input('Podaj c: ');

if a == 0
    if b == 0
        if c == 0
            disp('Równanie jest tożsamościowe.');
        else
            disp('Równanie jest sprzeczne.');
        end
    else
        x = -c / b;
        fprintf('Równanie liniowe z jednym rozwiązaniem: x = %f\n', x);
    end
else
    delta = b^2 - 4 * a * c;

    if delta < 0
        disp('Brak miejsc zerowych w dziedzinie liczb rzeczywistych (są w dziedzinie liczb zespolonych).');
    elseif delta == 0
        x = -b / (2 * a);
        fprintf('Jedno podwójne miejsce zerowe: x = %f\n', x);
    else
        x1 = (-b - sqrt(delta)) / (2 * a);
        x2 = (-b + sqrt(delta)) / (2 * a);
        fprintf('Dwa miejsca zerowe: x1 = %f, x2 = %f\n', x1, x2);
    end
end































