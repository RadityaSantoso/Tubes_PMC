
#define MAX_DATE_LENGTH 11  

// Struktur Riwayat3

typedef struct {
    int no;
    char tanggal[MAX_DATE_LENGTH];
    char id_pasien[20];
    char diagnosis[50];
    char tindakan[50];
    char kontrol[MAX_DATE_LENGTH];
    int biaya;
} Riwayat3;

// Struktur untuk setiap node pada linked list
typedef struct Node3 {
    Riwayat3 data;
    struct Node3* next;
} Node3;

Node3* createLinkedListFromFile(const char* filename);
void printPatientInfoByControlDate(Node3* head, int day, int month, int year);
void printLinkedList(Node3* head);
void freeLinkedList(Node3* head);
/*
int main() {
    // membuka linked list dari file
    Node3* head = createLinkedListFromFile("C:\\Users\\denni\\Desktop\\Tubes_PMC-main\\Cleanedriwayatpasien.csv");
    if (head != NULL) {

        // deklarasi hari,bulan,tahun
        int day, month, year;

        scanf("%d %d %d", &year, &month, &day);

        printf("Info pasien yang dikontrol pada tanggal %d-%d-%d:\n", year, month, day);
        printPatientInfoByControlDate(head, day, month, year);

        // membebaskan memori yang teralokasi
    } else {
        printf("Failed to create linked list.\n");
    }

    return 0;
}
*/
Node3* createLinkedListFromFile(const char* filename) {
    FILE* file = fopen(filename, "r");
    if (file == NULL) {
        perror("Error opening file");
        return NULL;
    }

    Node3* head = NULL;
    Node3* tail = NULL;
    char line[512];  

    
    fgets(line, sizeof(line), file);

    while (fgets(line, sizeof(line), file)) {
        Riwayat3 record;
        sscanf(line, "%d,%[^,],%[^,],%[^,],%[^,],%[^,],%d",
               &record.no, record.tanggal, record.id_pasien, record.diagnosis,
               record.tindakan, record.kontrol, &record.biaya);

        // membuat node3 untuk record
        Node3* newNode3 = (Node3*)malloc(sizeof(Node3));
        if (newNode3 == NULL) {
            fprintf(stderr, "Memory allocation failed\n");
            fclose(file);
            freeLinkedList(head); 
            return NULL;
        }
        newNode3->data = record;
        newNode3->next = NULL;

        // membuat node3 baru
        if (head == NULL) {
            head = newNode3;
            tail = newNode3;
        } else {
            tail->next = newNode3;
            tail = newNode3;
        }
    }

    fclose(file);
    return head;
}
// fungsi print info dari waktu kontrol
void printPatientInfoByControlDate(Node3* head, int day, int month, int year) {
    Node3* current = head;
    int found = 0;

    while (current != NULL) {
        int control_day, control_month, control_year;
        sscanf(current->data.kontrol, "%d-%d-%d", &control_year, &control_month, &control_day);

        if (control_day == day && control_month == month && control_year == year) {
            printf("ID Pasien: %s, Tindakan: %s, Diagnosis: %s, Biaya: %d\n",
                   current->data.id_pasien, current->data.tindakan,
                   current->data.diagnosis, current->data.biaya);
            found = 1;
        }

        current = current->next;
    }

    if (!found) {
        printf("Tidak ada pasien yang dikontrol pada tanggal %d-%d-%d.\n", day, month, year);
    }
}

void printLinkedList(Node3* head) {
    Node3* current = head;
    while (current != NULL) {
        printf("No: %d, Tanggal: %s, ID Pasien: %s, Diagnosis: %s, Tindakan: %s, Kontrol: %s, Biaya: %d\n",
               current->data.no, current->data.tanggal, current->data.id_pasien,
               current->data.diagnosis, current->data.tindakan, current->data.kontrol,
               current->data.biaya);
        current = current->next;
    }
}

void freeLinkedList(Node3* head) {
    Node3* current = head;
    while (current != NULL) {
        Node3* next = current->next;
        free(current);
        current = next;
    }
}
