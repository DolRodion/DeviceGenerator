<!-- Main page -->
<template>
  <div class="dinamicBlock">
    <v-row >
      <v-col class="d-flex" sm="4">
        <v-select v-model="selectedType" :items="items"  label="Тип Устройства" dense></v-select>
      </v-col>

      <v-col sm="4">
        <v-select v-model="selectedStatus" :items="itemsStatus"  label="Статус Устройства" dense></v-select>
      </v-col>
      <v-col sm="4">
        <v-btn @click="Sort"> Фильтровать </v-btn>
      </v-col>
    </v-row>
    <v-data-table
      @click:row="handleClick"
      :headers="headers"
      :items="getDevices"
      :items-per-page="15"
      class="elevation-1"
    ></v-data-table>
  </div>
</template>

<script lang="ts">
import { DeviceService, DeviceModel } from "@/AxiosSetup/service";
import { Component, Vue } from "vue-property-decorator";

@Component({
  components: {},
})
export default class Device extends Vue {
  public devices: DeviceModel[] = [];

  public items = ["TYPE1", "TYPE2", "TYPE3"];

  public itemsStatus = ["Работает", "Не работает","На ремонте"];

  public stringPath = "/Devices/AboutDevice/";

  public checkbox!:boolean;

  public selectedType : string = null!;
  public selectedStatus : string = null!;

  data() {
    return {
      headers: [
        { text: "Id", align: "start", sortable: false, value: "Id" },
        { text: "Тип устройства", value: "DeviceType" },
        { text: "Серийный номер", value: "SerialNumber" },
        { text: "Статус", value: "Status" },
        { text: "Адресс", value: "Address" },
        { text: "Последняя активность", value: "LastActivity" },
        { text: "Обьем буфера", value: "BufferSize" },
        { text: "Температура", value: "Temperature" },
      ],
    };
  }

  async created() {
    try {
      this.devices = await DeviceService.GetDevices();
    } catch {
      alert("Ошибка получения устройств");
    }
  }

  async Sort()
  {
    try {
      this.devices = await DeviceService.GetDevices(this.selectedType ,this.selectedStatus);
    } catch {
      alert("Ошибка получения устройств");
    }
    
  }

  handleClick(itemDevice: any) {
    this.$router.push({name: "AboutDevice",params: { idDevice: String(itemDevice.Id) },});
  }
  get getDevices() {
    return this.devices;
  }
}
</script>

<style>
.dinamicBlock {
  max-width: 1600px;
  margin: auto;
}

.v-data-table td {
  font-size: 15px !important;
}

.v-data-table th {
  font-size: 12px !important;
  font-weight: bolt;
}
</style>
