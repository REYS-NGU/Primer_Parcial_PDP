#include <stdio.h>

void calcular_pi_iterativo(int pasos, double *resultado) {
    double termino = 1.0;
    int signo = 1;

    for (int j = 0; j < pasos; j++) {
        *resultado += signo * (4.0 / termino); 
        termino += 2.0;                        
        signo *= -1;                          
    }
}

void calcular_pi_recursivo(int pasos, int j, double termino, int signo, double *resultado) {
    if (j >= pasos) {
        return; 
    }

    *resultado += signo * (4.0 / termino); 
    calcular_pi_recursivo(pasos, j + 1, termino + 2.0, signo * -1, resultado);
}

int main() {
    int iteraciones;
    double pi_iterativo = 0.0;
    double pi_recursivo = 0.0;

    printf("Ingrese el numero de iteraciones: ");
    scanf("%d", &iteraciones);

    calcular_pi_iterativo(iteraciones, &pi_iterativo);
    calcular_pi_recursivo(iteraciones, 0, 1.0, 1, &pi_recursivo);

    printf("Resultado de Pi con funcion iterativa: %.30f\n", pi_iterativo);
    printf("Resultado de Pi con funcion recursiva: %.30f\n", pi_recursivo);

    return 0;
}
