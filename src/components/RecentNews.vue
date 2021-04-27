<template>
  <v-card>
    <v-card-title>Recent News in GPXG Lab</v-card-title>
    <v-card-text>
      <v-list dense>
        <v-list-item-group color="primary">
          <v-container
            id="scroll-target"
            style="max-height: 200px"
            class="overflow-y-auto"
          >
            <v-list-item v-for="(info, i) in news" :key="i">
              {{ info.date }} {{ info.content }}
            </v-list-item>
          </v-container>
        </v-list-item-group>
      </v-list>
    </v-card-text>
  </v-card>
</template>
<script>
export default {
  data: () => ({
    news: [
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by ISBI 2021.'
      },
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by ISBI 2021.'
      },
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by ISBI 2021.'
      },
      {
        date: '2021.01.09',
        content: 'Our paper has been accepted by ISBI 2021.'
      },
      {
        date: '2020.09.17',
        content: 'Our paper has been accepted by ACM SIGGRAPH ASIA 2020 Technical Communications.'
      }
    ]
  })
}
</script>
