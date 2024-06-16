void remove_string_end_line(char str[MAX]){
    if(str[strlen(str)-1]=='\n'){
        str[strlen(str)-1]='\0';
    }
}
Pasien* cari_data_pasien(Pasien* head, char nama_pasien[MAX]){
    remove_string_end_line(nama_pasien);
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


void input_data_pasien_baru(Pasien* pasien){
    char temp_string[MAX];
    int temp_int;    
    printf("\nMasukkan nama baru pasien: ");
    fgets(temp_string,MAX,stdin);
    if(temp_string[0]=='\n'||temp_string[0]=='\0'){ //error checker dengan fgets
        fgets(temp_string,MAX,stdin);
    }
    remove_string_end_line(temp_string);
    strcpy(pasien->nama_lengkap,temp_string);
    printf("Masukkan alamat baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->alamat,temp_string);
    printf("Masukkan kota baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->kota,temp_string);
    printf("Masukkan tempat lahir baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->tempat_lahir,temp_string); 
    printf("Masukkan tanggal lahir baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->tanggal_lahir,temp_string);
    printf("Masukkan umur baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    temp_int=atoi(temp_string);
    pasien->umur=temp_int;
    printf("Masukkan nomor BPJS baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->no_bpjs,temp_string);
    printf("Masukkan id baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->id_pasien,temp_string); 
}

void mengubah_data_pasien(Pasien* head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);
    if(nama_pasien[0]=='\n'||nama_pasien[0]=='\0'){ //error checker dengan fgets
        fgets(nama_pasien,MAX,stdin);
    }

    //Pencarian
    Pasien* pasien = cari_data_pasien(head, nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }

    //Pengubahan
    input_data_pasien_baru(pasien);
}

void menambah_data_pasien(Pasien** head){
    //Penambahan (pada akhir csv)
    if(*head==NULL){
        Pasien* temp = malloc(sizeof(Pasien));
        input_data_pasien_baru(temp);
        temp->next=NULL;
        *head=temp;
        return;
    }
    Pasien* temp = *head;
    while(temp->next!=NULL){
        temp=temp->next;
    }
    temp->next=malloc(sizeof(Pasien));
    input_data_pasien_baru(temp->next);
    temp->next->next=NULL;
    return;
}

void menghapus_data_pasian(Pasien** head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);
    if(nama_pasien[0]=='\n'||nama_pasien[0]=='\0'){ //error checker dengan fgets
        fgets(nama_pasien,MAX,stdin);
    }

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
        printf("Penghapusan pasien %s berhasil.", nama_pasien);
        return;
    }
    Pasien* temp=*head;
    while(temp->next!=pasien){
        temp=temp->next;
    }
    temp->next=pasien->next;
    free(pasien);
    printf("Penghapusan pasien %s berhasil.", nama_pasien);
    return;
}

void print_pasien(Pasien* head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);
    if(nama_pasien[0]=='\n'||nama_pasien[0]=='\0'){ //error checker dengan fgets
        fgets(nama_pasien,MAX,stdin);
    }

    //Pencarian
    Pasien* pasien = cari_data_pasien(head,nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }

    printf("Pasien:\n\nNama Lengkap: %s\nAlamat: %s\nKota: %s\nTempat Lahir: %s\nTanggal Lahir: %s\nUmur: %d\nNo. BPJS: %s\nID Pasien: %s\n\n"
            ,pasien->nama_lengkap,pasien->alamat,pasien->kota,pasien->tempat_lahir,pasien->tanggal_lahir,pasien->umur,pasien->no_bpjs,pasien->id_pasien);
    
}


void first_date_format(char* str){
    if(strcmp(str, "Januari")==0){
        strcpy(str,"01");
    }
    else if(strcmp(str, "Februari")==0){
        strcpy(str,"02");
    }
    else if(strcmp(str, "Maret")==0){
        strcpy(str,"03");
    }
    else if(strcmp(str, "April")==0){
        strcpy(str,"04");
    }
    else if(strcmp(str, "Mei")==0){
        strcpy(str,"05");
    }
    else if(strcmp(str, "Juni")==0){
        strcpy(str,"06");
    }
    else if(strcmp(str, "Juli")==0){
        strcpy(str,"07");
    }
    else if(strcmp(str, "Agustus")==0){
        strcpy(str,"08");
    }
    else if(strcmp(str, "September")==0){
        strcpy(str,"09");
    }
    else if(strcmp(str, "Oktober")==0){
        strcpy(str,"10");
    }
    else if(strcmp(str, "November")==0){
        strcpy(str,"11");
    }
    else if(strcmp(str, "Desember")==0){
        strcpy(str,"12");
    }

}

void second_date_format(char* str){
    if(strcmp(str, "Jan")==0){
        strcpy(str,"01");
    }
    else if(strcmp(str, "Feb")==0){
        strcpy(str,"02");
    }
    else if(strcmp(str, "Mar")==0){
        strcpy(str,"03");
    }
    else if(strcmp(str, "Apr")==0){
        strcpy(str,"04");
    }
    else if(strcmp(str, "Mei")==0){
        strcpy(str,"05");
    }
    else if(strcmp(str, "Jun")==0){
        strcpy(str,"06");
    }
    else if(strcmp(str, "Jul")==0){
        strcpy(str,"07");
    }
    else if(strcmp(str, "Agu")==0){
        strcpy(str,"08");
    }
    else if(strcmp(str, "Sep")==0){
        strcpy(str,"09");
    }
    else if(strcmp(str, "Okt")==0){
        strcpy(str,"10");
    }
    else if(strcmp(str, "Nov")==0){
        strcpy(str,"11");
    }
    else if(strcmp(str, "Des")==0){
        strcpy(str,"12");
    }
}

char* format_date(const char* str){
    int len = strlen(str);

    //checker if format 1 or 2 {1 is spaces, 2 is -'s}, default 2
    char delimiter;
    char* checker=strchr(str, '-');
    if(checker==NULL){
        delimiter=' ';
    }
    else{
        delimiter='-';
    }

    //splitting
    //char* temp = strchr(str,delimiter);
    char* temp = strchr(str, delimiter);
    char day[5];
    int starting_index=0;
    for(int i=starting_index; i<temp-str;i++){
        day[i-starting_index]=str[i];
    }
    day[temp-str-starting_index]='\0';

    char month[MAX];
    starting_index=temp-str+1;
    temp=strchr(temp+1,delimiter);
    for(int i=starting_index; i<temp-str;i++){
        month[i-starting_index]=str[i];
    }
    month[temp-str-starting_index]='\0';

    char year[5];
    starting_index=temp-str+1;
    for(int i=starting_index; i<len;i++){
        year[i-starting_index]=str[i];
    }
    year[len-starting_index]='\0';


    char* output=malloc(sizeof(MAX));
    for(int i=0; i<strlen(year);i++){
        output[i]=year[i];
    }
    if(delimiter=='-'){
        second_date_format(month);
    }
    else{
        first_date_format(month);
    }
    output[strlen(year)]=month[0];
    output[strlen(year)+1]=month[1];
    if(strlen(day)==1){
        output[2+strlen(year)]='0';
        output[3+strlen(year)]=day[0];
    }
    else{
        output[2+strlen(year)]=day[0];
        output[3+strlen(year)]=day[1];
    }
    output[4+strlen(year)]='\0';
    return output;
}
