<template>
  <v-card flat>
    <v-card-title>Recent News</v-card-title>
    <v-card-text>
      <v-list dense>
        <v-list-item-group color="">
          <v-container
            id="scroll-target"
            style="max-height: 200px"
            class="overflow-y-auto"
          >
            <v-list-item v-for="(info, i) in news" :key="i" >
              <b>【{{info.date}}】</b>  <div v-html="info.content" class="ml-2"></div>
            </v-list-item>
          </v-container>
        </v-list-item-group>
      </v-list>
    </v-card-text>
  </v-card>
</template>
<style lang="css" scoped>

</style>
<script>
export default {
  props: ['recentNews'],
  data: () => ({
    news: []
  }),
  mounted () {
    this.news = this.recentNews
  }
}
</script>
