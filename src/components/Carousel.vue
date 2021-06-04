<template>
  <v-carousel class="i-carousel" hide-delimiter-background show-arrows-on-hover >
    <!-- <v-carousel-item
      v-for="(item, i) in items"
      :key="i"
      :src="item.src"
    ></v-carousel-item> -->
    <v-carousel-item
      v-for="(item, i) in imgItem"
      :key="i"
      :src="item"
    ></v-carousel-item>
  </v-carousel>
</template>

<style lang="css" scoped>

</style>

<script>

// @ is an alias to /src
// import HelloWorld from '@/components/HelloWorld.vue'

export default {
  props: ['imgItem'],
  data: () => ({
    items: [
    ]
  })
}
</script>
