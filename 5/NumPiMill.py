import multiprocessing as mp
import decimal

decimal.getcontext().prec = 100  # Ajusta la precisión deseada


def calcular_segmento_nilakantha(inicio, fin):
    suma_parcial = decimal.Decimal(0)
    signo = 1
    for i in range(inicio, fin):
        n = 2 + 2 * i
        termino = decimal.Decimal(4) / (n * (n + 1) * (n + 2))
        suma_parcial += signo * termino
        signo *= -1
    return suma_parcial


def calcular_pi_con_multiprocessing(iteraciones, num_procesadores):
    chunk_size = iteraciones // num_procesadores

    rangos = [(i * chunk_size, (i + 1) * chunk_size) for i in range(num_procesadores)]

    if iteraciones % num_procesadores != 0:
        rangos[-1] = (rangos[-1][0], iteraciones)

    with mp.Pool(processes=num_procesadores) as pool:
        resultados = pool.starmap(calcular_segmento_nilakantha, rangos)

    suma_total = sum(resultados)
    pi_aproximado = decimal.Decimal(3) + suma_total

    return pi_aproximado


if __name__ == "__main__":
    iteraciones = 1_000_000
    num_procesadores = mp.cpu_count()

    pi_aproximado = calcular_pi_con_multiprocessing(iteraciones, num_procesadores)

    print(f"Valor aproximado de Pi con {iteraciones} términos: {pi_aproximado}")
