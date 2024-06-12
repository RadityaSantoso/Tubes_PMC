//#include header.c

Pasien* cari_data_pasien(Pasien* head, const char* nama_pasien){
    if (head==NULL){
        printf("Data kosong\n");
        return NULL;
    }
    Pasien* temp=head;
    while(temp!=NULL){
        if(strcmp(temp->nama_lengkap, nama_pasien)==0){
            return temp;
        }
        temp=temp->next;
    }
    return NULL;
}

void mengubah_data_pasien(Pasien* head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);

    //Pencarian
    Pasien* pasien = cari_data_pasien(head, nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }


}

void menambah_data_pasien(Pasien** head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);

    //Pencarian
    Pasien* pasien = cari_data_pasien(*head, nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }


}

void menghapus_data_pasian(Pasien** head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);

    //Pencarian
    Pasien* pasien = cari_data_pasien(*head, nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }

    //Penghapusan
    if(*head==pasien){
        *head=pasien->next;
        free(pasien);
        return;
    }
    Pasien* temp=*head;
    while(temp->next!=pasien){
        temp=temp->next;
    }
    temp->next=pasien->next;
    free(pasien);
}