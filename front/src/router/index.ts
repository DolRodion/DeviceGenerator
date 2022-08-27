import Vue from 'vue';
import VueRouter, { RouteConfig } from 'vue-router';
import Device from '../views/Device.vue';
import AboutDevice from '../views/AboutDevice.vue';

Vue.use(VueRouter);

const routes: RouteConfig[] = [
  {
    path: '/',
    name: 'Device',
    component: Device,
  }, 

  {
    path: '/Devices/AboutDevice/:idDevice',
    name: 'AboutDevice',
    component: AboutDevice,
    props: true,
  }, 

];

const router = new VueRouter({
  routes,
});

export default router;
