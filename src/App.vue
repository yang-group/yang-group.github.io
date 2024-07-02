<template>
  <v-app id="app">
    <v-app-bar id="nav" height="88" app class="justify-space-between">
      <a href="https://yang-group.github.io/">
        <v-img
          class="logo flex-grow-1 ml-10"
          contain
          max-width="150px"
          max-height="85px"
          src="./assets/logo.png"
          alt="人工智能学院"
        />
      </a>
      <v-tabs id="tabs" class="flex-grow-1 mr-5" active right>
        <v-tabs-slider color="#4582B4"></v-tabs-slider>
        <v-tab to="/">
          <strong>
            Home
          </strong>
        </v-tab>
        <v-tab to="/people">
          <strong>
            Member
          </strong>
        </v-tab>
        <!-- <v-tab to="/research">
          Research
        </v-tab> -->
        <v-tab to="/publication">
          <strong>
            Publication
          </strong>
        </v-tab>
        <v-tab to="/Contact">
          <strong>
            Contact
          </strong>
        </v-tab>
        <v-tab to="/Awards">
          <strong>
            Awards
          </strong>
        </v-tab>
      </v-tabs>
    </v-app-bar>
    <v-container class="main" fluid>
      <router-view />
    </v-container>

    <!-- <template>
    <v-footer padless id="footer">
    <v-col class="text-center" cols="12">
      {{ new Date().getFullYear() }} — <strong>GPXG</strong>
    </v-col>
  </v-footer>
  </template> -->
  </v-app>
</template>

<style lang="scss">
a,
a:hover {
  text-decoration: none;
  color: black;
  font-family: Arial, Helvetica, sans-serif;
}
strong {
  color: #4582B4;
}
#nav {
  // background-image: linear-gradient(25deg, #1f6170, #4a7f94, #719eb9, #99bee0);
  // background-image: linear-gradient(84deg, #3c1b8a, #4959a2, #4691ba, #1cccd2);
  // background-image: linear-gradient(184deg, #577eaf, #498698, #279988);
  background-color: #F2F4FA;
  box-shadow: none;
  overflow: hidden;
}
#footer {
  width: 100%;
  position: fixed;
  bottom: 0;
  background-image: linear-gradient(25deg, #1f6170, #4a7f94, #719eb9, #99bee0);
}
</style>
