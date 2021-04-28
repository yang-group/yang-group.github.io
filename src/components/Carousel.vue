<template>
  <v-carousel class="i-carousel" hide-delimiter-background show-arrows-on-hover >
    <v-carousel-item
      v-for="(item, i) in items"
      :key="i"
      :src="item.src"
    ></v-carousel-item>
  </v-carousel>
</template>

<style lang="css" scoped>

</style>

<script>

// @ is an alias to /src
// import HelloWorld from '@/components/HelloWorld.vue'

export default {
  // name: 'Home',
  // components: {
  //   HelloWorld
  // }
  data: () => ({
    items: [
      {
        src: 'http://sai.jlu.edu.cn/images/20210416-1.jpg'
      },
      {
        src: 'http://sai.jlu.edu.cn/images/20210326.jpg'
      },
      {
        src: 'http://sai.jlu.edu.cn/images/20210315.jpg'
      },
      {
        src: 'http://sai.jlu.edu.cn/images/gongxun.jpg'
      },
      {
        src: 'http://sai.jlu.edu.cn/images/20210317.jpg'
      }
    ]
  })
}
</script>
