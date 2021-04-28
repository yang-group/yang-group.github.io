<template>
  <v-app id="app">
    <v-app-bar id="nav" height="88px" app class="justify-space-between">
      <v-img class="logo flex-grow-1 ml-5" contain src="./assets/logo.png" alt="人工智能学院" />
      <v-tabs id="tabs" class="flex-grow-1 mr-5" right color="pink darken-1">
        <v-tab to="/">
          Home
        </v-tab>
        <v-tab to="/people">
          People
        </v-tab>
        <!-- <v-tab to="/research">
          Research
        </v-tab> -->
        <v-tab to="/publication">
          Publication
        </v-tab>
      </v-tabs>
    </v-app-bar>
    <v-container class="main mt-5">
      <router-view/>
    </v-container>
  </v-app>
</template>

<style lang="scss">
a, a:hover {
  text-decoration:none;
  color: black;
  font-family: Arial, Helvetica, sans-serif;
}
#nav {
  background-image: linear-gradient(25deg, #1f6170, #4a7f94, #719eb9, #99bee0)
}
</style>
