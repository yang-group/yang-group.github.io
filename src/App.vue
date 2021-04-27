<template>
  <v-app id="app">
    <v-app-bar id="nav" height="88px" app>
      <v-img class="logo" contain src="./assets/logo.png" alt="人工智能学院" />
      <v-spacer></v-spacer>
      <v-tabs id="tabs" class="ml-10">
        <v-tab to="/">
          Home
        </v-tab>
        <v-tab to="/people">
          People
        </v-tab>
        <v-tab to="/research">
          Research
        </v-tab>
        <v-tab to="/publication">
          Publication
        </v-tab>
      </v-tabs>
    </v-app-bar>
    <v-main class="main">
      <router-view/>
    </v-main>
  </v-app>
</template>

<style lang="scss">
a, a:hover {
  text-decoration:none;
  color: black;
  font-family: Arial, Helvetica, sans-serif;
}
.main {
  width: 80%;
  margin: 0 auto;
}
</style>
