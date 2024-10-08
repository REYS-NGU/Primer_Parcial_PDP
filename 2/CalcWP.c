#include <stdio.h>

// Funciones para realizar operaciones básicas
int sumar(int x, int y) {
    return x + y;
}

int restar(int x, int y) {
    return x - y;
}

int multiplicar(int x, int y) {
    return x * y;
}

float dividir(int x, int y) {
    if (y != 0) {
        return (float)x / y;
    } else {
        return 0;  // Manejo de la división por cero
    }
}

int main() {
    int num1, num2;

    // Solicitar entrada al usuario
    printf("Ingrese el primer numero: ");
    scanf("%d", &num1);
    printf("Ingrese el segundo numero: ");
    scanf("%d", &num2);
    
    // Mostrar resultados de las operaciones
    printf("Suma: %d + %d = %d \n", num1, num2, sumar(num1, num2));
    printf("Resta: %d - %d = %d \n", num1, num2, restar(num1, num2));
    printf("Multiplicacion: %d * %d = %d \n", num1, num2, multiplicar(num1, num2));

    if (num2 != 0) {
        printf("Division: %d / %d = %.4f \n", num1, num2, dividir(num1, num2));
    } else {
        printf("Division: Indeterminado (división por cero) \n");
    }

    return 0;
}
