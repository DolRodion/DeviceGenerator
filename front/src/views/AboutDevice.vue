<template>
  <div class="blackout-block">
    <div v-if="isLoading">
      <p><b>Тип устройства </b>{{ device.DeviceType }}</p>
      <p><b>Серийный номер устройства </b>{{ device.SerialNumber }}</p>
      <p><b>Место установки устройства </b>{{ device.Address }}</p>
      <p><b>Статус работоспособности устройства </b>{{ device.Status }}</p>
    </div>
  </div>
</template>
<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { DeviceService, DeviceModel } from "@/AxiosSetup/service";
@Component({
  components: {},
})
export default class AboutDevice extends Vue {
  public device!: DeviceModel;
  public isLoading = false;

  async created() {
    try {
      if (this.$route.params.idDevice == "") {
        alert("Неверный гуид");
      }
      this.device = await DeviceService.GetDeviceById(
        this.$route.params.idDevice
      );
    } catch {
      alert("Ошибка получения устройства");
    }

    this.isLoading = true;
  }
}
</script>
<style scoped>

</style>