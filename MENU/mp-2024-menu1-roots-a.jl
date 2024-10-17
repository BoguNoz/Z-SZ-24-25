eq1(x) = exp(x)-sin(x);
function bisection(f,a,b,maxiter,err)
# f - przekazywana funkcja np. eq1
# a,b - zakres dziaªania metody
# maxiter - maksymalna liczba interacji
# delta - dopuszczalny bª¡d dªugo±ci zakresu
# err - dopuszczalny bª¡d warto±ci funkcji

    if (sign(f(a)) != sign(f(b))) 
        println("Brak miejsc zerowych w podanym przedziale") 
        return 
    end

    for i in 1:maxiter
        c = a - (a/2) + (b/2)
        if(abs(f(c)) < err)
            println("Nasze miejsce zerowe to: ", c)
            return;
        end

        if(sign(f(a)) == sign(f(c)))
            b = c 
        else
            a = c
        end

    end

end


bisection(eq1, -1, -3, 1000, 0.00001)


