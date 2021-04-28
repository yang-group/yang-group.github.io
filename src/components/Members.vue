<template>
    <div class="lighten-2">
      <v-container>
        <v-row>
          <template v-for="(value,key,index) in std_cat" >
            <v-col
              :key="index"
              class="mt-2"
              cols="12"
              v-show="value.length != 0"
            >
              <h2>{{ key }}</h2>
            </v-col>

            <v-col
              v-for="(stu,idx) in value"
              :key="`${key}${idx}`"
              cols="auto"
              md="2"
            >
              <v-sheet>
                <Student :stu="stu" />
              </v-sheet>
            </v-col>
          </template>
        </v-row>
      </v-container>
    </div>
</template>

<script>
import Student from '@/components/Student'

export default {
  props: {

  },
  components: {
    Student
  },
  data: () => ({
    std_cat: {
      PhD: [
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal', 'CV', 'NLP'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' }
      ],
      Master: [
        { name: 'Tang Chuan', year: '2020-Now', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' },
        { name: 'Tang Chuan', year: '2020-Now', email: 'tangchuan20@mails.jlu.edu.cn', inerest: ['3D Deep Learning', 'Mutli-modal'], photo: 'img/yangxi.png', github: 'JLUtangchuan' }
      ],
      Album: []
    }
  })
}
</script>

<style>

</style>
