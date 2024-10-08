#include <stdio.h>

void sumar_p(int x, int y, int *resultado) {
    *resultado = x + y;
}


void restar_p(int x, int y, int *resultado) {
    *resultado = x - y;
}

void multiplicar_p(int x, int y, int *resultado) {
    int i;
    *resultado = x*y;
}

void dividir_p(int x, int y, float *resultado) {
    if (y != 0) {
        *resultado = (float)x / y;
    } else {
        printf("Division: Indeterminado\n");
    }
}

int main() {
    int num1, num2, res_int;
    float res_float;

    printf("Ingrese el primer numero: ");
    scanf("%d", &num1);
    printf("Ingrese el segundo numero: ");
    scanf("%d", &num2);

    sumar_p(num1, num2, &res_int);
    printf("Suma: %d + %d = %d\n", num1, num2, res_int);

    restar_p(num1, num2, &res_int);
    printf("Resta: %d - %d = %d\n", num1, num2, res_int);

    multiplicar_p(num1, num2, &res_int);
    printf("Multiplicacion: %d * %d = %d\n", num1, num2, res_int);

    dividir_p(num1, num2, &res_float);
    if (num2 != 0) {
        printf("Division: %d / %d = %.4f\n", num1, num2, res_float);
    }

    return 0;
}
