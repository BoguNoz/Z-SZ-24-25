eq(x) = exp(x)-sin(x)-1
der(x) = exp(x)-cos(x) 

function newton(f,d,a,maxiter,err)

    for i in 1:maxiter
        der = d(a)
        if(der == 0)
            println("Dzielenie przez 0")
            return;
        end
        a = a-f(a)/der;
        if abs(f(a)) < err
            println("Miejsce zerowe = ", a)
            return
        end
    end
    println("Nie udało się zbiec do punktu zerowego");
end

newton(eq,der,0,1000,0.00001)