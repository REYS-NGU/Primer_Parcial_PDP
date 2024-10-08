#include <mpi.h>
#include <stdio.h>
#include <string.h>

#define VECTOR_SIZE 6
#define MAX_STRING_LENGTH 100

int main(int argc, char* argv[]) {
    int rank, size;
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank); // Rango del proceso
    MPI_Comm_size(MPI_COMM_WORLD, &size); // Número total de procesos

    char vector[VECTOR_SIZE][MAX_STRING_LENGTH]; // Vector de cadenas
    int num_elements = VECTOR_SIZE;

    if (rank == 0) {
        // Inicialización del vector de cadenas
        strcpy(vector[0], "cadena_0");
        strcpy(vector[1], "cadena_1");
        strcpy(vector[2], "cadena_2");
        strcpy(vector[3], "cadena_3");
        strcpy(vector[4], "cadena_4");
        strcpy(vector[5], "cadena_5");

        // Enviar el vector de cadenas a los otros procesos
        MPI_Send(&vector, VECTOR_SIZE * MAX_STRING_LENGTH, MPI_CHAR, 1, 0, MPI_COMM_WORLD);
        MPI_Send(&vector, VECTOR_SIZE * MAX_STRING_LENGTH, MPI_CHAR, 2, 0, MPI_COMM_WORLD);
    } else if (rank == 1) {
        // Proceso 1: recibir el vector y desplegar las posiciones pares
        MPI_Recv(&vector, VECTOR_SIZE * MAX_STRING_LENGTH, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);

        printf("Proceso 1 - Posiciones pares:\n");
        for (int i = 0; i < num_elements; i += 2) {
            printf("Posicion %d: %s\n", i, vector[i]);
        }
    } else if (rank == 2) {
        // Proceso 2: recibir el vector y desplegar las posiciones impares
        MPI_Recv(&vector, VECTOR_SIZE * MAX_STRING_LENGTH, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);

        printf("Proceso 2 - Posiciones impares:\n");
        for (int i = 1; i < num_elements; i += 2) {
            printf("Posicion %d: %s\n", i, vector[i]);
        }
    }

    MPI_Finalize();
    return 0;
}
