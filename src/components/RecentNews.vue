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
  data: () => ({
    news: [
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by <b>ISBI</b> 2021.'
      },
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by <b>ISBI</b> 2021.'
      },
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by <b>ISBI</b> 2021.'
      },
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by <b>ISBI</b> 2021.'
      },
      {
        date: '2020.09.17',
        content: 'Our paper has been accepted by ACM <b>SIGGRAPH ASIA</b> 2020 Technical Communications.'
      }
    ]
  })
}
</script>
