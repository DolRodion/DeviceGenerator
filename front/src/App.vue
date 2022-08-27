<template>
  <v-app>
    <!--Header -->
    <div class="header">
      <router-link class="title" to="/"></router-link>
    </div>

    <!--Content block -->
    <div class="content">
      <router-view />
    </div>
  </v-app>
</template>

<style>
* {
  margin: 0;
  padding: 0;
}

body {
  background-color: #fafafa;
}

.title {
  color: #fafafa;
}

.header {
  position: fixed;
  z-index: 100000;
  width: 100%;
  height: 50px;
  padding: 10px 10px;
  background-color: #1c89e6;
}

.content {
  position: relative;
  top: 50px;
  padding: 20px 40px;
}
</style>
