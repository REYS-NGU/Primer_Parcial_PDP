def serie_fibo(tamaño):
    fibos = []
    rho = (1 + 5**0.5) / 2
    for x in range(tamaño):
        fibonacci = round((rho**x - (-1 / rho) ** x) / 5**0.5)
        fibos.append(fibonacci)
    return fibos


cantFibos = 30
Fibonacci = serie_fibo(cantFibos)
print(Fibonacci)
