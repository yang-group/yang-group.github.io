<template>
  <v-main class="home">
    <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
    <!-- <HelloWorld msg="Welcome to Your Vue.js App"/> -->
    <v-row>
      {{welcome}}
    </v-row>
    <v-row class="">
      <v-col>
        <v-banner>
        <div id="intro"> {{intro}} </div>
        <div id="carousel"></div>
      </v-banner>
      </v-col>
      <v-col>
        <Carousel/>
        <RecentNews/>

      </v-col>
    </v-row>

  </v-main>
</template>
<style lang="css" scoped>

</style>
<script>

// @ is an alias to /src
import Carousel from '@/components/Carousel.vue'
import RecentNews from '@/components/RecentNews.vue'

export default {
  // name: 'Home',
  components: {
    Carousel,
    RecentNews
  },
  data: () => ({
    welcome: 'Welcome To GPXG！！！',
    intro: '实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍',
    items: [
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/squirrel.jpg'
      },
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/sky.jpg'
      },
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/bird.jpg'
      },
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/planet.jpg'
      }
    ]
  })
}
</script>
